using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ekitap.entity;

namespace ekitap.webui.Models

{
    public class KategoriModel
    {
        public int kategoriId { get; set; }


        [Display(Name="Kategori Adı:",Prompt="kategori adı yazınız")]
        [Required(ErrorMessage="kategori adı zorunlu bir alan")]
        public string ka_adi { get; set; }
        [Required(ErrorMessage="url zorunlu bir alan")]
        public string Url { get; set; }
        public List<kitap> kitaplar { get; set; }
    }
}