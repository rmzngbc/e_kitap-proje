using ekitap.entity;
using System.Collections.Generic;

namespace ekitap.webui.Models
{
    public class YazarModel
    {
        public int yazarId { get; set; }
        public string yazarad { get; set; }
        public string yazarsoyad { get; set; }
        public List<kitap> kitaplar { get; set; }

        public List<yazar> yazarlar { get; set; }
    }
}