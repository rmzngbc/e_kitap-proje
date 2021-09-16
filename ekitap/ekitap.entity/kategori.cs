using System.Collections.Generic;
namespace ekitap.entity
{
    public class kategori
    {
        public int kategoriId { get; set; }

        public string ka_adi { get; set; }
        public string Url { get; set; }
        
        public List<kitap> kitaplar { get; set; }
    }
}