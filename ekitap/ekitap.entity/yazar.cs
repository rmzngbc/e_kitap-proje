using System.Collections.Generic;
namespace ekitap.entity
{
    public class yazar
    {
        public int yazarId { get; set; }
        public string yazarad { get; set; }
        public string yazarsoyad { get; set; }
        public List<kitapyazar> kitapyazarlar { get; set; }
    }
}