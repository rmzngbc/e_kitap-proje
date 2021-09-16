using System.Collections.Generic;
using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;


namespace ekitap.data.Concrete.EfCore
{
    public class EfCorekitapRepository : 
          EfCoreGenericRepository<kitap, ekitapContext>, IkitapRepository
    {
        //bir ürüne ait bilgileri ve o ürüne ait katerogi bilgilerini;
            //listeleyelim

        public kitap GetById(int id)
        {
            using (var db=new ekitapContext())
            {   
                
                return db.kitaplar
                          .Where(i=>i.kitapId==id)
                          .Include(i=>i.kategori)
                          .FirstOrDefault();
                 
            }
        }

        //--kategoriye göre kitapları listeleme:
        //--sayfalama
        public List<kitap> GetkitapBykategori(string kategoriad,int page,int pageSize)
        {
            using (var db=new ekitapContext())
            {
                 var kitaps=db.kitaplar.AsQueryable();

                 if(!string.IsNullOrEmpty(kategoriad))
                 {
                     kitaps=kitaps
                                .Where(i=>i.kategori.Url.ToLower()==kategoriad.ToLower());

                 }

                 return kitaps.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        //ürün detay metod:

        public kitap GetkitapDetails(string url)
        {
            using (var db=new ekitapContext())
            {
                   return db.kitaplar
                          .Where(i=>i.Url==url)
                          .Include(i=>i.kategori)
                          .FirstOrDefault();
                 
            }
         
        }

        //kategoriye göre kitap sayısı:
        public int GetCountByCategory(string category)
        {
           using (var db = new ekitapContext())
            {
                var kitaplar = db.kitaplar.AsQueryable();

                if(!string.IsNullOrEmpty(category))
                {
                    kitaplar = kitaplar
                                    .Where(i=>i.kategori.ka_adi.ToLower()==category.ToLower());
                                    
                }

                return kitaplar.Count();
            }
        }

        public List<kitap> GetHomePagekitaplar(string kategoriad,int page,int pageSize)
        {
            using (var db=new ekitapContext())
            {

                 var kitaps=db.kitaplar
                        .Where(i=>i.k_anasayfa)
                        .AsQueryable();

                 if(!string.IsNullOrEmpty(kategoriad))
                 {
                     kitaps=kitaps
                                .Where(i=>i.kategori.Url.ToLower()==kategoriad.ToLower());

                 }

                 return kitaps.Skip((page-1)*pageSize).Take(pageSize).ToList();
                 
            }
            
        }

        //--kelimeye göre kitap ara:
        //--kitap onaylı ve aranan kelimeyi içeriyrsa.

        public List<kitap> KitapAra(string KelimeAra)
        {
            using (var db=new ekitapContext())
            {
                return db.kitaplar
                        .Where(i=>i.k_onay && (i.k_adi.ToLower().Contains(KelimeAra.ToLower()))).ToList();
                 
            }
            
        }

      

    }
}