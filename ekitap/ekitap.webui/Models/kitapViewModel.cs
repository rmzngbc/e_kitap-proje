using System.Collections.Generic;
using ekitap.entity;
using System;

namespace ekitap.webui.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }


        public int TotalPages()
        {
             return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
        }


    }

    


    public class kitapListViewModel
    {
        public List<kitap> Kitaplar { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}