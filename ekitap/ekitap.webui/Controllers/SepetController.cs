using System.Linq;
using ekitap.business.Abstract;
using ekitap.webui.Identity;
using ekitap.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ekitap.webui.Controllers
{
    [Authorize]
    public class SepetController:Controller
    {
        private ISepetService _sepetService;
        private UserManager<User> _userManager;

        public SepetController(ISepetService sepetService,UserManager<User> userManager)
        {
            _sepetService=sepetService;
            _userManager=userManager;

        }


        //--bir user ın sepeti    
        public IActionResult SepetList()
        {   
            
            /*
            --login olan userın userid ne göre db den sepet bilgileri sepet;
                değişkenine aktarıldı.
            */
            var sepet=_sepetService.GetSepetByUserId(_userManager.GetUserId(User));




            return View(new SepetModel(){
                SepetId=sepet.Id,
                SepetItems=sepet.SepetItems.Select(i=>new SepetItemModel()
                {
                    SepetItemId=i.Id,
                    kitapId=i.kitapId,
                    kitapadi=i.kitap.k_adi,
                    kitapfiyat=(double)i.kitap.k_fiyat,
                    kitapresim=i.kitap.k_resim,
                    kitapadet=i.Adet
                }).ToList()


            });
        }


        //--sepete kitap ekleme:
        [HttpPost]
        public IActionResult AddToSepet(int kitapId,int adet)
        {   

            //--login olan user ın userId bilgisi alındı    
            var userId=_userManager.GetUserId(User);

            _sepetService.AddToSepet(userId,kitapId,adet);


            return RedirectToAction("SepetList");
        }

        //--sepete eklenen kitapları sepetten silme:
        [HttpPost]
        public IActionResult DeleteFromSepet(int kitapId)
        {
            //login olan user ın userid si alındı
            var userId=_userManager.GetUserId(User);

            _sepetService.DeleteFromSepet(userId,kitapId);

            return RedirectToAction("SepetList");
        }

        //--updatetosepet:sepet güncellee,kitap ekle veya çıkar:

        [HttpPost]
        public IActionResult UpdateToSepet(int SepetItemId,int kitapId,int adet)
        {
            
            //--ilk önce login olan user ın userId sini alalım:
            var userId=_userManager.GetUserId(User);

            _sepetService.UpdateToSepet(userId,SepetItemId,kitapId,adet);

            return RedirectToAction("SepetList");
        }



    }
}