using System.Collections.Generic;
using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;
using System;


namespace ekitap.data.Concrete.EfCore
{
    public class EfCorekitapRepository : 
          EfCoreGenericRepository<kitap, ekitapContext>, IkitapRepository
    {
      
        /*
        --bir kitaba ait(kitapId sine göre),kitap bilgilerini,hangi kategoriye,yayinevine ait olduğunu ve kitabın yazar-yazarlarını listeleyelim:
        */    
        public kitap GetById(int id)
        {
            using (var db=new ekitapContext())
            {   
                
                return db.kitaplar
                          .Where(i=>i.kitapId==id)
                          .Include(i=>i.kitapyazarlar)
                          .ThenInclude(i=>i.yazar)
                          .Include(i=>i.kategori)
                          .Include(i=>i.yayinevi)
                          .FirstOrDefault();
                
                
                /*
                --SQL sorgusu:

                SELECT ki.kitapId,ki.k_adi,ka.ka_adi,ye.yayineviAd,ya.yazarad
                FROM kitaplar as ki JOIN kategoriler as ka on ki.kategoriId=ka.kategoriId
                JOIN yayinevleri as ye on ki.yayineviId=ye.yayineviId
                JOIN kitapyazar as ky on ki.kitapId=ky.kitapId
                JOIN yazarlar as ya on ky.yazarId=ya.yazarId
                WHERE ki.kitapId=2;
                */


                



                 
            }
        }

        //--kategoriye göre kitapları listeleme:
        //--sayfalama
        //--sıralama işlemi
        public List<kitap> GetkitapBykategori(string kategoriad,string sirala,int page,int pageSize)
        {       
            
            //--dropdows da -en yüksek fiyat- seçilirse,kategori seçildikten sonra:
            if (sirala=="max")
            {

                using (var db=new ekitapContext())
                {
                    var kitaps=db.kitaplar.AsQueryable();

                    if(!string.IsNullOrEmpty(kategoriad))
                    {
                        kitaps=kitaps
                                    .Where(i=>i.kategori.Url.ToLower()==kategoriad.ToLower())
                                    .OrderByDescending(i=>i.k_fiyat);
                        
                        /*
                        --SQL Sorgusu:
                        -- seçilen kategoriye göre listelenen kitapları fiyat sırasına göre sıralayalım:

                        SELECT * from kategoriler as ka JOIN kitaplar as ki on ka.kategoriId=ki.kategoriId
                        where ka.ka_adi='Roman' order by ki.k_fiyat desc;
                        */

                    }

                    return kitaps.Skip((page-1)*pageSize).Take(pageSize).OrderByDescending(i=>i.k_fiyat).ToList();
                }
                
            }

            //--dropdown da --en düşük fiyat seçilirse,kategori seçildikten sonra--

            if (sirala=="min")
            {

                using (var db=new ekitapContext())
                {
                    var kitaps=db.kitaplar.AsQueryable();

                    if(!string.IsNullOrEmpty(kategoriad))
                    {
                        kitaps=kitaps
                                    .Where(i=>i.kategori.Url.ToLower()==kategoriad.ToLower())
                                    .OrderBy(i=>i.k_fiyat);

                    }

                    return kitaps.Skip((page-1)*pageSize).Take(pageSize).ToList();
                }
                
            }


            //-zamana göre en yeniler:
            
            if (sirala=="zaman")
            {

                using (var db=new ekitapContext())
                {
                    var kitaps=db.kitaplar.AsQueryable();

                    if(!string.IsNullOrEmpty(kategoriad))
                    {
                        kitaps=kitaps
                                    .Where(i=>i.kategori.Url.ToLower()==kategoriad.ToLower())
                                    .Where(i=>i.EkZaman>=DateTime.Now.AddDays(-7) && i.EkZaman<=DateTime.Now);
                                   

                    }

                    /*
                        --SQL Sorgusu:
                        --ilgili kategorriye göre son bir hafta içinde eklenen kitapları listeleyelim:(en yeniler):

                          SELECT * from kategoriler as ka JOIN kitaplar as ki on ka.kategoriId=ki.kategoriId
                        where ki.EkZaman BETWEEN dateadd(day,-7,getdate()) and  getdate();          
                    */

                    return kitaps.Skip((page-1)*pageSize).Take(pageSize).ToList();
                }
                
            }






            //--eğer sıralam işlemi yapılmasdıysa 
            using (var db=new ekitapContext())
            {
                 var kitaps=db.kitaplar.AsQueryable();

                 if(!string.IsNullOrEmpty(kategoriad))
                 {
                     kitaps=kitaps
                                .Where(i=>i.kategori.Url.ToLower()==kategoriad.ToLower());
                                //.OrderByDescending(i=>i.k_fiyat);

                 }

                 return kitaps.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        //kitap detay metod:

        public kitap GetkitapDetails(string url)
        {
            using (var db=new ekitapContext())
            {
                   return db.kitaplar
                          .Where(i=>i.Url==url)
                          .Include(i=>i.kategori)
                          .Include(i=>i.kitapyazarlar)
                          .ThenInclude(i=>i.yazar)
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

                /*
                --SQL Sorgusu:

                --kategori adlarına göre kitap adetletini listeleyelim:

                    SELECT ka.ka_adi as kategoriad,count(ki.kitapId) as kitap_adet
                    from kategoriler as ka JOIN kitaplar as ki on ka.kategoriId=ki.kategoriId
                    group by ka.ka_adi;


                */

                return kitaplar.Count();
            }
        }

        public List<kitap> GetHomePagekitaplar(string kategoriad,int page,int pageSize)
        {
            using (var db=new ekitapContext())
            {

                 var kitaps=db.kitaplar
                        //.Where(i=>i.k_anasayfa)
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
                        .Where(i=>i.k_adi.ToLower().Contains(KelimeAra.ToLower())).ToList();
                

                /*
                    --SQL Sorgusu:
                    -- aranılan kelimeye göre kitap arama:
                    SELECT * from kitaplar  where k_adi like '%_____%';
                */
            }
            
        }

        //--kitap ekleme yazar ile:
        public void Create(kitap entity,int[] yazarIds)
        {   

            //Console.WriteLine(yazarIds);
            using (var db=new ekitapContext())
            {   
               
               
                db.kitaplar.Add(entity);
                db.SaveChanges();

                
                var kitap=db.kitaplar
                                    .OrderByDescending(i=>i.kitapId)
                                    .FirstOrDefault();
                
               
                kitap.kitapyazarlar=yazarIds.Select(yazid=>new kitapyazar()
                {
                    yazarId=yazid,
                    kitapId=kitap.kitapId

                }).ToList();
               

                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                Console.WriteLine("güncelleme işlemi gerçekleşti.");
               
                
            }

            
        }

        //--kitap güncelleme,kategori ve yazarları,yayinevi ile birlikte:


        public void Update(kitap entity,int kategoriIds,int[] yazarIds,int yayineviIds)
        {
            using (var db=new ekitapContext())
            {
                var kitap=db.kitaplar
                            .Include(i=>i.kitapyazarlar)
                            .FirstOrDefault(i=>i.kitapId==entity.kitapId);

                if(kitap!=null)
                {
                        //kitap.kitapId=entity.kitapId;
                        kitap.k_adi=entity.k_adi;
                        kitap.Url=entity.Url;
                        kitap.k_fiyat=entity.k_fiyat;
                        kitap.k_sayfa=entity.k_sayfa;
                        kitap.k_resim=entity.k_resim;
                        kitap.k_aciklama=entity.k_aciklama;
                        kitap.kategoriId=kategoriIds;
                        kitap.yayineviId=yayineviIds;
                        
                        kitap.kitapyazarlar=yazarIds.Select(yazid=>new kitapyazar()
                        {
                            kitapId=entity.kitapId,
                            yazarId=yazid
                        }).ToList();
                        
                        db.SaveChanges();
                }
                 
            }


        }

        //kitap entity sindeki toplam kitap sayısı:

        public int GetCountsKitap()
        {
            using (var db=new ekitapContext())
            {
                return db.kitaplar.Count();
                 
            }
        }

      
    }
}