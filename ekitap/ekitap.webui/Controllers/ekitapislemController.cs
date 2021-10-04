using Microsoft.AspNetCore.Mvc;
using ekitap.business.Abstract;
using ekitap.entity;
using ekitap.data.Abstract;
using System;
using System.Collections.Generic;
using ekitap.webui.Models;

namespace ekitap.webui.Controllers
{
    public class ekitapislemController:Controller
    {
        
        private IkitapService _kitapService;
        private IyazarService _yazarService;
        public ekitapislemController(IkitapService kitapService,IyazarService yazarService)
        {
            this._kitapService=kitapService;
            this._yazarService=yazarService;
        }

        //--kitap ayrıntı metodu:

        public IActionResult Details(string url)
        {
            if (url==null)
            {
                return NotFound();
            }
            
            //dbye gönderilen id ye göre işlem yapılacak.
            kitap kitap=_kitapService.GetkitapDetails(url);

            if (kitap==null)
            {
                return NotFound();
            }
            return View(kitap);


        }

        //--kategori adlarına göre kitapların listelenmesi:
        public IActionResult List(string kategori,string sirala,int page=1)
        {   
            
            ViewBag.kategoriadi=kategori;
            ViewBag.siralamalar=sirala;
            const int pageSize=4;

            var kitap_ka=new kitapListViewModel()
            {
                
                PageInfo = new PageInfo()
                {
                    TotalItems = _kitapService.GetCountByCategory(kategori),
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = kategori
                },


                Kitaplar=_kitapService.GetkitapBykategori(kategori,sirala,page,pageSize)
            };

            return View(kitap_ka);
        }

        //--kitap ara:
        public IActionResult kitapara(string q)
        {
            var kitap_ara=new kitapListViewModel()
            {

                Kitaplar=_kitapService.KitapAra(q)

               
            };
            return View(kitap_ara);

        }


        /*
        --ilk harfi yazılan harf olan yazarları listeleyelim:
        */
        //--yazarlar:
        public IActionResult yazarlar(string harf,int id)
        {
            
            
          
            
            var yazark=new YazarModel()
            {
                yazarlar=_yazarService.YazarListHarf(harf,id)
            };

            
            ViewBag.yazarlar=_yazarService.YazarListHarf(harf);
          
         
            return View(yazark);
        }

       

       

      


        
    }
}