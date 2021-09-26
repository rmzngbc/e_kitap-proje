using System.Collections.Generic;
using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;

namespace ekitap.data.Concrete.EfCore
{
    public class EfCoreyazarRepository:EfCoreGenericRepository<yazar, ekitapContext>, IyazarRepository
    {
        public yazar GetById(int Id)
        {
            using (var db=new ekitapContext())
            {
                return db.yazarlar.Where(i=>i.yazarId==Id)
                                   .Include(i=>i.kitapyazarlar)
                                   .ThenInclude(i=>i.kitap) 
                                   .FirstOrDefault();
                 
            }

        }

        //--yazılan harfe göre yazarları listeleme-ve bu yazarın kitaplarını listeleme::

        public List<yazar> YazarListHarf(string harf)
        {
            using (var db=new ekitapContext())
            {
                return db.yazarlar.Where(i=>i.yazarad.StartsWith(harf))
                                  .Include(i=>i.kitapyazarlar)
                                  .ThenInclude(i=>i.kitap)  
                                  .ToList();
                 
            }
        }


        public List<yazar> YazarListHarf(string harf,int id)
        {
            using (var db=new ekitapContext())
            {
                 return db.yazarlar.Where(i=>i.yazarad.StartsWith(harf) && i.yazarId==id)
                                  .Include(i=>i.kitapyazarlar)
                                  .ThenInclude(i=>i.kitap)  
                                  .ToList();
                 
            }
        }
    }
}