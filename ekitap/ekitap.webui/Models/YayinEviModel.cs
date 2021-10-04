using System.Collections.Generic;
using ekitap.entity;

namespace ekitap.webui.Models
{
    public class YayinEviModel
    {
        public int yayineviId { get; set; }
        public string yayineviAd { get; set; }

        public List<kitap> kitaplar { get; set; }
        
    }
}