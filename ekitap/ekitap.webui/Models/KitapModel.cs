using System.ComponentModel.DataAnnotations;
using ekitap.entity;
using System.Collections.Generic;

namespace ekitap.webui.Models
{
    public class KitapModel
    {

        public int kitapId { get; set; }
        [Display(Name="Kitap Adı:",Prompt="kitap adı yazınız")]
        [Required(ErrorMessage="kitap adi zorunlu bir alan")]
        public string k_adi { get; set; }
        [Required(ErrorMessage="Url zorunlu bir alan")]
        public string Url { get; set; }
        [Display(Name="Fiyat:")]
        [Required(ErrorMessage="fiyat zorunlu bir alan")]
        [Range(1,1000,ErrorMessage="fiyat için 1-1000 arasında değer giriniz")]
        public double? k_fiyat { get; set; }
        [Required(ErrorMessage="sayfa zorunlu bir alan")]
        [Display(Name="Sayfa:")]
        public int k_sayfa { get; set; }
        [Display(Name="Kitap Açıklama:")]
        [Required(ErrorMessage="açıklama zorunlu bir alan")]
        [StringLength(250,MinimumLength=5,ErrorMessage="açıklama 5-250 karakter aralığında olmalıdır.")]
        public string k_aciklama { get; set; }
        [Display(Name="Resim:")]
        [Required(ErrorMessage="resim zorunlu bir alan")]
        public string k_resim { get; set; }
        public bool k_onay { get; set; }
        public bool k_anasayfa { get; set; }
        [Display(Name="Kategori:")]
        public kategori kategori { get; set; }
        [Required(ErrorMessage="kategoriId zorunlu bir alan")]
        public int kategoriId { get; set; }
        public kategori selectedkategori { get; set; }
        //yazar
        public yazar yazar { get; set; }
        public List<yazar> yazarId { get; set; }
        public List<yazar> selectedyazarlar { get; set; }

        public int yayineviId { get; set; }
    }
}