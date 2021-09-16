using System.Collections.Generic;
using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;
using ekitap.entity;


namespace ekitap.data.Concrete.EfCore
{
    public class EfCorekategoriRepository:
          EfCoreGenericRepository<kategori, ekitapContext>, IkategoriRepository
    {

        //--id ye göre kategori düzenleme:
        public kategori GetById(int id)
        {
            using (var db=new ekitapContext())
            {   
                
                return db.kategoriler
                          .Where(i=>i.kategoriId==id)
                          .Include(i=>i.kitaplar)
                          .FirstOrDefault();
                 
            }
        }

        //--kategoriye edit e göre db den kitap silme:
        public void deletefromkategori(int kitapId)
        {
            using (var db=new ekitapContext())
            {
               var cmd="delete from kitaplar where kitapId=@p0";
               db.Database.ExecuteSqlRaw(cmd,kitapId);
                 
            }
        }
    }
}