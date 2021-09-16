using ekitap.entity;
using System.Collections.Generic;

namespace ekitap.data.Abstract
{
    public interface IkitapRepository:IRepository<kitap>
    {
        kitap GetById(int id);

        List<kitap> GetkitapBykategori(string kategoriad,int page,int pageSize);

        kitap GetkitapDetails(string url);

        int GetCountByCategory(string category);


        //--anasayfadaki kitapların onaylı olanların gösterilmesi.
        List<kitap> GetHomePagekitaplar(string kategoriad,int page,int pageSize);

        
        List<kitap> KitapAra(string KelimeAra);

        


    }
}