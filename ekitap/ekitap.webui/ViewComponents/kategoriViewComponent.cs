
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ekitap.business.Abstract;

namespace ekitap.webui.ViewComponents
{
    public class kategoriViewComponent:ViewComponent
    {
        private IkategoriService _kategoriService;
        public kategoriViewComponent(IkategoriService kategoriService)
        {
            this._kategoriService=kategoriService;
        }

        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["kategori"]!=null)
                ViewBag.SelectedCategory = RouteData?.Values["kategori"];
          
            return View(_kategoriService.GetAll());
        }

    }
}