using System.Collections.Generic;

namespace ekitap.entity
{
    public class yayinevi
    {
        public int yayineviId { get; set; }
        public string yayineviAd { get; set; }

        public List<kitap> kitaplar { get; set; }
    }
}