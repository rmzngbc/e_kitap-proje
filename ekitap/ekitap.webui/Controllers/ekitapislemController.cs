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
        public ekitapislemController(IkitapService kitapService)
        {
            this._kitapService=kitapService;
        }

        //--kitap ayrın metodu:

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
        public IActionResult List(string kategori,int page=1)
        {   
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


                Kitaplar=_kitapService.GetkitapBykategori(kategori,page,pageSize)
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


        
    }
}