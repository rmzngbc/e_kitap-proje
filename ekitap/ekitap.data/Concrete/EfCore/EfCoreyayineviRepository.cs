using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;

namespace ekitap.data.Concrete.EfCore
{
    public class EfCoreyayineviRepository : EfCoreGenericRepository<yayinevi, ekitapContext>, IyayineviRepository
    {   

        //--yayinevi id sine göre yayınevi bilgilerini ve bu yayınevine ait kitapları listeleyelim:
        public yayinevi GetById(int id)
        {
            using (var db=new ekitapContext())
            {
                 
                 return db.yayinevleri.Where(i=>i.yayineviId==id)
                                      .Include(i=>i.kitaplar)
                                      .FirstOrDefault();


            }

        }
    }
}