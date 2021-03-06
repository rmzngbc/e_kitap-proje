using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ekitap.business.Abstract;
using ekitap.entity;
using ekitap.webui.Models;



using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ekitap.webui.Identity;
using System.Collections.Generic;

namespace ekitap.webui.Controllers
{   

    //Admin rolüne sahip userlar controller kısmında erişebilecek
    [Authorize(Roles="Admin")]
    public class AdminController:Controller
    {
        private IkitapService _kitapService;
        private IkategoriService _kategoriService;
        private IyazarService _yazarService;

        private IyayineviService _yayineviService;

        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;

        public AdminController(IkitapService kitapService,
                               IkategoriService kategoriService,
                               IyazarService yazarService,
                               IyayineviService yayineviService,
                               RoleManager<IdentityRole> roleManager,
                               UserManager<User> userManager)
        {

            this._kitapService=kitapService;
            this._kategoriService=kategoriService;
            this._yazarService=yazarService;
            this._yayineviService=yayineviService;
            this._roleManager=roleManager;
            this._userManager=userManager;

        }




        //--admin panelinde db deki userları listeleme:
        public IActionResult UserList()
        {   
            
            return View(_userManager.Users);
        }



        //--admin--UserEdit sayası oluşturma:

        public async Task<IActionResult> UserEdit(string id)
        {
            var user=await _userManager.FindByIdAsync(id);
            if (user!=null)
            {


                var selectedRoles=await _userManager.GetRolesAsync(user);

                var roles=_roleManager.Roles.Select(i=>i.Name);
                ViewBag.Roles=roles;


                return View(new UserDetailsModel(){
                    UserId = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });




                
            }

            //--eğer user bilgisi yok ise:
            return Redirect("~/admin/user/list");

        }


        //user edit--post:

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model,string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {

                 var user=await _userManager.FindByIdAsync(model.UserId);

                 if (user!=null)
                 {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles?? new string[]{};
                        await _userManager.AddToRolesAsync(user,selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user,userRoles.Except(selectedRoles).ToArray<string>());

                        return Redirect("/admin/user/list");





                    }


                     
                 }

                 return Redirect("/admin/user/list");





            }

            return View(model);

        }



        //role-edit:
        //ilgili role ait olan ve olmayan userları listeleyebiliyoruz:
        public async Task<IActionResult> RoleEdit(string id)
        {   


            var role=await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonmembers = new List<User>();

            //--db deki User ı dolaşalım:
            foreach (var user in _userManager.Users)
            {
                var list=await _userManager.IsInRoleAsync(user,role.Name)
                                    ?members:nonmembers;
                list.Add(user);
                
            }


            var model=new RoleDetails()
            {
                Role=role,
                Members=members,
                NonMembers=nonmembers
            };

            return View(model);

        }





        //
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {


                foreach (var userId in model.IdsToAdd ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if(user!=null)
                    {   
      
                        var result = await _userManager.AddToRoleAsync(user,model.RoleName);
                        /*
                        --eğer atama başarılı değilse,tek tek hataları dolaşıyoruz,
                        */
                        if(!result.Succeeded)
                        {
                              foreach (var error in result.Errors)
                              { 
                                ModelState.AddModelError("", error.Description);  
                              }  
                        }
                    }
                }
                
            
            
                foreach (var userId in model.IdsToDelete ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if(user!=null)
                    {   
                      
                        var result = await _userManager.RemoveFromRoleAsync(user,model.RoleName);
                        if(!result.Succeeded)
                        {
                              foreach (var error in result.Errors)
                              { 
                                ModelState.AddModelError("", error.Description);  
                              }  
                        }
                    }
                }
            }


            return Redirect("/admin/role/edit/"+model.RoleId);



        }


        //--role list action metodu oluşturuldu
        public IActionResult RoleList()
        {
            //role tablosundaki bütün kayıtlar listelenip,view e aktarılacak
            return View(_roleManager.Roles);

        }

        //--rol ekleme:

        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> RoleCreate(RoleModel model)
        {   

            //role oluşturma:
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                
                
                if(result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("",error.Description);
                        
                    }
                }
            }
            //modelstate de bir hata varsa:
            return View(model);
        }


        public IActionResult KitapList()
        {
            var adminkitap=new kitapListViewModel()
            {
                Kitaplar=_kitapService.GetAll()
                
            };

            //--kitap entity sindeki toplam kitap sayısı:
            ViewBag.CountKitap=_kitapService.GetCountsKitap();
            return View(adminkitap);
        }

        //admin kitap ekleme:

        [HttpGet]
        public IActionResult KitapEkle()
        {
            //db den bütün kategorileri bir değişkene aktaralım:
            ViewBag.kategoriler=_kategoriService.GetAll();
            ViewBag.yazarlar=_yazarService.GetAll();
            ViewBag.yayinevleri=_yayineviService.GetAll();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KitapEkle(KitapModel model,int[] yazarIds,IFormFile file)
        {   

            //--validasyon işlemi,client validation
            
                var entity=new kitap()
                {
                    k_adi=model.k_adi,
                    Url=model.Url,
                    k_fiyat=model.k_fiyat,
                    k_sayfa=model.k_sayfa,
                    //k_resim=model.k_resim,
                    k_aciklama=model.k_aciklama,
                    kategoriId=model.kategoriId,
                    yayineviId=model.yayineviId,
                    EkZaman=DateTime.Now,
                    

                };

                if (file!=null)
                {
                    Console.WriteLine(file.FileName);
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    entity.k_resim = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);

                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }




                
                _kitapService.Create(entity,yazarIds);


                var msg = new AlertMessage()
                {            
                    Message = $"{entity.k_adi} isimli ürün eklendi.",
                    AlertType = "success"
                };

               

                TempData["message"] =  JsonConvert.SerializeObject(msg);
                return RedirectToAction("KitapList");
            
            



        }

        //--kitap güncelleme:
        //--bir kitaptaki db de var olan bilgileri güncellemek için:
        
        [HttpGet]
        public IActionResult KitapEdit(int? id)
        {

            if(id==null)
            {
                return NotFound();
            }

            var entity=_kitapService.GetById((int)id);

            if(entity==null)
            {
                 return NotFound();
            }

            var model=new KitapModel()
            {
                kitapId=entity.kitapId,
                k_adi=entity.k_adi,
                Url=entity.Url,
                k_fiyat=entity.k_fiyat,
                k_sayfa=entity.k_sayfa,
                k_resim=entity.k_resim,
                k_aciklama=entity.k_aciklama,
                selectedkategori=entity.kategori,
                selectedyazarlar=entity.kitapyazarlar.Select(i=>i.yazar).ToList(),
                selectedyayinevi=entity.yayinevi
            };

            //db den bütün kategorileri bir değişkene aktaralım:
            ViewBag.kategoriler=_kategoriService.GetAll();
            //db deki yazarları bir değişkene atayalım:
            ViewBag.yazarlar=_yazarService.GetAll();
            //den bütün yayınevlerini bir değişkene atayalım:
            ViewBag.yayınevleri=_yayineviService.GetAll();

            return View(model);




        }

        //--kitap bilgilerini güncelleme ve kategori bilgisini de güncelleme.
        [HttpPost]
        public IActionResult KitapEdit(KitapModel model,int kategoriIds,int[] yazarIds,int yayineviIds)
        {   
            //Console.WriteLine(kategoriIds);
            var entity = _kitapService.GetById(model.kitapId);
            if(entity==null)
            {
                return NotFound();
            }

            entity.kitapId=model.kitapId;
            entity.k_adi=model.k_adi;
            entity.Url=model.Url;
            entity.k_fiyat=model.k_fiyat;
            entity.k_sayfa=model.k_sayfa;
            entity.k_resim=model.k_resim;
            entity.k_aciklama=model.k_aciklama;
            entity.kategoriId=kategoriIds;
            entity.yayineviId=yayineviIds;
           
            
            
            //günelleme işlemi:
            //bir kitaba ait kategoriler de güncellenebilir.
            _kitapService.Update(entity,kategoriIds,yazarIds,yayineviIds);

            var msg = new AlertMessage()
            {            
                Message = $"{entity.k_adi} isimli ürün güncellendi.",
                AlertType = "success"
            };

            TempData["message"] =  JsonConvert.SerializeObject(msg);

            return RedirectToAction("KitapList");

        }

        //ide ye göre db den kitap sil:
        
        public IActionResult KitapDelete(int kitapId)
        {
            var  entity=_kitapService.GetById(kitapId);
            
            if(entity!=null)
            {
                _kitapService.Delete(entity);
            }

            var msg = new AlertMessage()
            {            
                Message = $"{entity.k_adi} isimli ürün silindi.",
                AlertType = "success"
            };

            TempData["message"] =  JsonConvert.SerializeObject(msg);    

            return RedirectToAction("KitapList");
        }

        //--kategori listeleme:
        public IActionResult KategoriList()
        {
            
            return View(new KategoriListViewModel()
            {
                Kategoriler=_kategoriService.GetAll()
              
            });
        }

        //--kategori ekle:
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(KategoriModel model)
        {
            var entity=new kategori()
            {
                ka_adi=model.ka_adi,
                Url=model.Url
            };

            _kategoriService.Create(entity);


              var msg = new AlertMessage()
            {            
                Message = $"{entity.ka_adi} isimli category eklendi.",
                AlertType = "success"
            };

            TempData["message"] =  JsonConvert.SerializeObject(msg);

            return RedirectToAction("KategoriList");

        }

        //--kategori güncelleme:
        [HttpGet]
        public IActionResult KategoriEdit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var entity=_kategoriService.GetById((int)id);

            var model=new KategoriModel()
            {
                kategoriId=entity.kategoriId,
                ka_adi=entity.ka_adi,
                Url=entity.Url,
                kitaplar=entity.kitaplar
            };

            return View(model);

        }

        [HttpPost]
        public IActionResult KategoriEdit(KategoriModel model)
        {   
            var entity = _kategoriService.GetById(model.kategoriId);
            if(entity==null)
            {
                return NotFound();
            }

            entity.ka_adi=model.ka_adi;
            entity.Url=model.Url;

            _kategoriService.Update(entity);

            var msg = new AlertMessage()
            {            
                Message = $"{entity.ka_adi} isimli category güncellendi.",
                AlertType = "success"
            };

            TempData["message"] =  JsonConvert.SerializeObject(msg);

            return RedirectToAction("KategoriList");

        }

        //--kategori sil-id ye göre:
        public IActionResult KategoriDelete(int kategoriId)
        {

            var entity=_kategoriService.GetById(kategoriId);
            if(entity!=null)
            {
                _kategoriService.Delete(entity);
            }

            var msg = new AlertMessage()
            {            
                Message = $"{entity.ka_adi} isimli kategori silindi.",
                AlertType = "danger"
            };

            TempData["message"] =  JsonConvert.SerializeObject(msg);

            return RedirectToAction("KategoriList");


        }

        //--kategori edit den kitap sil:
        [HttpPost]
        public IActionResult DeleteFromKategori(int kitapId,int kategoriId)
        {
            _kategoriService.deletefromkategori(kitapId);

            return Redirect("/admin/kategoriler/edit/"+kategoriId);

        }

        //--yazar list:
      
        public IActionResult YazarList()
        {
            var model=new yazarListViewModel()
            {
                yazarlar=_yazarService.GetAll()

            };

            return View(model);

        }

        //yazar ekle:
        [HttpGet]
        public IActionResult YazarEkle()
        {
            return View();
        }


        [HttpPost]
        public IActionResult YazarEkle(YazarModel entity)
        {
            var model=new yazar()
            {
                yazarad=entity.yazarad,
                yazarsoyad=entity.yazarsoyad
            };

            _yazarService.Create(model);

            return RedirectToAction("YazarList");
            
            
        }

        //yazar edit:
        [HttpGet]
        public IActionResult YazarEdit(int? Id)
        {   
            var entity=_yazarService.GetById((int)Id);

            var model=new YazarModel()
            {   
                yazarId=entity.yazarId,
                yazarad=entity.yazarad,
                yazarsoyad=entity.yazarsoyad,
                kitaplar=entity.kitapyazarlar.Select(i=>i.kitap).ToList()
            };
            
            return View(model);
        }

        //yazar editleme işleminden sonra post metoduna gelecek
        [HttpPost]
        public IActionResult YazarEdit(YazarModel model)
        {   
            
            var entity=_yazarService.GetById(model.yazarId);
            if(entity==null)
            {
                return NotFound();
            }

            
            entity.yazarad=model.yazarad;
            entity.yazarsoyad=model.yazarsoyad;

            _yazarService.Update(entity);
            
            return RedirectToAction("YazarList");

        }

        //yayinevi-list:
        public IActionResult YayinEviList()
        {   
            var model=new yayineviListViewModel()
            {
                yayinevleri=_yayineviService.GetAll()
            };
            return View(model);
        }


        //yayinevi ekle:

        [HttpGet]
        public IActionResult YayinEviEkle()
        {

            return View();
        }


        //--yayinei ekle:
        [HttpPost]
        public IActionResult YayinEviEkle(YayinEviModel model)
        {   
            Console.WriteLine("eklendi mi?");
            var entity=new yayinevi()
            {
                yayineviAd=model.yayineviAd
            };  

            //kaydı db ye aktaralık:
            _yayineviService.Create(entity);
            return RedirectToAction("YayinEviList");
        }

        //yayinevi edit:
        [HttpGet]
        public IActionResult YayinEviEdit(int? id)
        {

            var  entity=_yayineviService.GetById((int)id);
            var model=new YayinEviModel()
            {

                yayineviId=entity.yayineviId,
                yayineviAd=entity.yayineviAd,
                kitaplar=entity.kitaplar

            };

            return View(model);
        }

        [HttpPost]
        public IActionResult YayinEviEdit(YayinEviModel model)
        {
            
            var entity=_yayineviService.GetById(model.yayineviId);
            entity.yayineviAd=model.yayineviAd;
            _yayineviService.Update(entity);

            Console.WriteLine("güncelleme tamamlandı");

            return RedirectToAction("YayinEviList");

        }




        //--admin paneli:
        public IActionResult AdminPanel()
        {
            return View();

        }







        
    }
}