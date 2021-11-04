using System.Collections.Generic;
using System.Linq;

namespace ekitap.webui.Models
{

    //--login olan usera ait db den gelen sepet bilgileri sepetmodel classındaki;
        //proplara aktarılacak.
    public class SepetModel
    {
        
        
            public int SepetId { get; set; }

            public List<SepetItemModel> SepetItems { get; set; }


            //--sepetteki kitapların toplamınu bulan metod:
            public double ToplamFiyat()
            {
                return SepetItems.Sum(i=>i.kitapfiyat*i.kitapadet);
            }
    }


        public class SepetItemModel
        {
            public int SepetItemId { get; set; }
            public int kitapId { get; set; }
            public string kitapadi { get; set; }
            public double kitapfiyat { get; set; }
            public string kitapresim { get; set; }
            public int kitapadet { get; set; }
            
        }


    
}