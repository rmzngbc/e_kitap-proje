using System.Collections.Generic;
namespace ekitap.entity
{
    public class kitap
    {
        public int kitapId { get; set; }
        public string k_adi { get; set; }
        public string Url { get; set; }
        public double? k_fiyat { get; set; }
        public int k_sayfa { get; set; }
        public string k_aciklama { get; set; }
        public string k_resim { get; set; }
        public bool k_onay { get; set; }
        public kategori kategori { get; set; }
        public int kategoriId { get; set; }
        public bool k_anasayfa { get; set; }
        public List<kitapyazar> kitapyazarlar { get; set; }

        public yayinevi yayinevi { get; set; }
        public int yayineviId { get; set; }
      
        

    }
}