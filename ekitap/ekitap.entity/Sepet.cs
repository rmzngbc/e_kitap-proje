using System.Collections.Generic;

namespace ekitap.entity
{
    public class Sepet
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public List<SepetItem> SepetItems { get; set; }
        
    }
}