using Microsoft.AspNetCore.Mvc;
using ekitap.business.Abstract;
using ekitap.webui.Models;
using ekitap.entity;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace ekitap.webui.Controllers
{
    public class AdminController:Controller
    {
        private IkitapService _kitapService;
        private IkategoriService _kategoriService;
        private IyazarService _yazarService;

        public AdminController(IkitapService kitapService,IkategoriService kategoriService,IyazarService yazarService)
        {
            this._kitapService=kitapService;
            this._kategoriService=kategoriService;
            this._yazarService=yazarService;

        }

        public IActionResult KitapList()
        {
            var adminkitap=new kitapListViewModel()
            {
                Kitaplar=_kitapService.GetAll()
            };
           
            return View(adminkitap);
        }

        //admin kitap ekleme:

        [HttpGet]
        public IActionResult KitapEkle()
        {
            //db den bütün kategorileri bir değişkene aktaralım:
            ViewBag.kategoriler=_kategoriService.GetAll();
            ViewBag.yazarlar=_yazarService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult KitapEkle(KitapModel model,int[] yazarIds)
        {   

            //--validasyon işlemi,client validation
            
                var entity=new kitap()
                {
                    k_adi=model.k_adi,
                    Url=model.Url,
                    k_fiyat=model.k_fiyat,
                    k_sayfa=model.k_sayfa,
                    k_resim=model.k_resim,
                    k_aciklama=model.k_aciklama,
                    kategoriId=model.kategoriId,
                    

                };


                
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
                selectedyazarlar=entity.kitapyazarlar.Select(i=>i.yazar).ToList()
            };

            //db den bütün kategorileri bir değişkene aktaralım:
            ViewBag.kategoriler=_kategoriService.GetAll();
            //db deki yazarları bir değişkene atayalım:
            ViewBag.yazarlar=_yazarService.GetAll();

            return View(model);




        }

        //--kitap bilgilerini güncelleme ve kategori bilgisini de güncelleme.
        [HttpPost]
        public IActionResult KitapEdit(KitapModel model,int kategoriIds,int[] yazarIds)
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
           
            
            
            //günelleme işlemi:
            //bir kitaba ait kategoriler de güncellenebilir.
            _kitapService.Update(entity,kategoriIds,yazarIds);

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

        //--admin paneli:
        public IActionResult AdminPanel()
        {

            return View();

        }







        
    }
}