using System.Collections.Generic;
using ekitap.entity;

namespace ekitap.business.Abstract
{
    public interface IkitapService
    {
       

        List<kitap> GetAll();

        void Create(kitap entity);

        void Update(kitap entity);
        void Delete(kitap entity);

        kitap GetById(int id);

        List<kitap> GetkitapBykategori(string kategoriad,int page,int pageSize);

        kitap GetkitapDetails(string url);


        //--kategoriye göre kitap sayısını geriye gönderecek.
        int GetCountByCategory(string category);

        List<kitap> GetHomePagekitaplar(string kategoriad,int page,int pageSize);

        List<kitap> KitapAra(string KelimeAra);

        void Create(kitap entity,int[] yazarIds);

       
    }
}