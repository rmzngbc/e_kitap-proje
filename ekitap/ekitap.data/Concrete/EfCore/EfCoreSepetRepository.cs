using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;

namespace ekitap.data.Concrete.EfCore
{
    public class EfCoreSepetRepository : EfCoreGenericRepository<Sepet, ekitapContext>, ISepetRepository
    {


        //--sepetten kitap silme:
        public void DeleteFromSepet(int sepetId,int kitapId)
        {
            using (var db=new ekitapContext())
            {
                var cmd=@"delete from SepetItems where sepetId=@p0 and kitapId=@p1";
                db.Database.ExecuteSqlRaw(cmd,sepetId,kitapId);
                 
            }
        }

        //--login olan kulalnıcının userıd si alınıp sepet,sepetıtems ve;
            //kitap bilgilerini db den alınıyor:
        public Sepet GetByUserId(string userId)
        {

            using (var db=new ekitapContext())
            {
                return db.Sepets
                          .Include(i=>i.SepetItems)
                          .ThenInclude(i=>i.kitap)
                          .FirstOrDefault(i=>i.UserId==userId);  
                 
            }


            /*
            --sql sorgusu:
            select * from Sepets as s JOIN SepetItems as sa on s.Id=sa.SepetId
            JOIN kitaplar as ki on sa.kitapId=ki.kitapId where s.Id='';
            */

        }

        //update işlemi,ana class taki update override edildi:
        public override void Update(Sepet entity)
        {
            using (var db=new ekitapContext())
            {
                db.Sepets.Update(entity);
                db.SaveChanges();
                 
            }

        }
    }
}