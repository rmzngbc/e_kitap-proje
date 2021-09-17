using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ekitap.business.Abstract;
using ekitap.data.Abstract;
using ekitap.webui.Models;

namespace ekitap.webui.Controllers
{
    public class HomeController:Controller
    {
        private IkitapService _kitapService;
        public HomeController(IkitapService kitapService)
        {
            this._kitapService=kitapService;
        }

        public IActionResult Index(string kategori,int page=1)
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


                Kitaplar=_kitapService.GetHomePagekitaplar(kategori,page,pageSize)
            };


        

            return View(kitap_ka);
        }
    }
}