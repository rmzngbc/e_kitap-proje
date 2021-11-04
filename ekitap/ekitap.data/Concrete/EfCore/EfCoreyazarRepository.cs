using System;
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

                /*
                    --SQL sorgusu:
                    -- yazarlara ait olan kitapları listeleyelim:

                        SELECT ya.yazarad,group_concat(ki.k_adi) as kitaplar
                        from yazarlar as ya JOIN kitapyazar as ky on ya.yazarId=ky.yazarId
                        JOIN kitaplar as ki on ky.kitapId=ki.kitapId
                        GROUP by ya.yazarad;
                */
                 
            }

        }

        //--yazılan harfe göre yazarları listeleme-ve bu yazarın kitaplarını listeleme::
        //--ara kısmına yazılan ad+soyad a göre yazar arama
        public List<yazar> YazarListHarf(string harf)
        {   

            //Console.WriteLine(harf);
            //Console.WriteLine(harf.Length);  
            //string abc="ramazan";
            //Console.WriteLine(abc);          
            using (var db=new ekitapContext())
            {   

                    
                    if (harf==null || harf.Length==1)
                    {
                        var yazarlar_bir= db.yazarlar.Where(i=>i.yazarad.StartsWith(harf))
                                                //.Include(i=>i.kitapyazarlar)
                                                //.ThenInclude(i=>i.kitap)  
                                                 .ToList();  

                        /*
                            --SQL Sorgusu:
                            --baş harfi "R" ile başlayan yazarları ve bu yazarlara ait olan kitapları listeleyelim:

                                SELECT (ya.yazarad + ' ' + ya.yazarsoyad) as yazarlar,
                                count(ki.kitapId) as adet
                                from yazarlar as ya JOIN kitapyazar as ky on ya.yazarId=ky.yazarId
                                JOIN kitaplar as ki on ky.kitapId=ki.kitapId where ya.yazarad like 'R%'
								group by (ya.yazarad + ' ' + ya.yazarsoyad);


                             
                        */


                        return yazarlar_bir;

                    }


                    else
                    {

                        

                        var cmd="SELECT  * from yazarlar as y where (y.yazarad  + ' ' + y.yazarsoyad)={0}";
                        return db.yazarlar.FromSqlRaw(cmd,harf).ToList();
                        


                        /*
                        return db.yazarlar.Where(i=>i.yazarad==harf)
                                          //Where(i=>i.yazarad==harf)
                                                //.Include(i=>i.kitapyazarlar)
                                                //.ThenInclude(i=>i.kitap)  
                                                 .ToList();
                        */
                        


                        

                    }
                    



                    /*
                    return db.yazarlar.Where(i=>i.yazarad.StartsWith(harf))
                                                //.Include(i=>i.kitapyazarlar)
                                                //.ThenInclude(i=>i.kitap)  
                                                 .ToList();
                    
                    */
                    


                    /*
                    return db.yazarlar.Where(i=>i.yazarad.ToLower().Contains(harf.ToLower()))
                                                .Include(i=>i.kitapyazarlar)
                                                .ThenInclude(i=>i.kitap)  
                                                 .ToList();
                    */

                /*
                return db.yazarlar.Where(i=>i.yazarad.StartsWith(harf))
                            .Include(i=>i.kitapyazarlar)
                            .ThenInclude(i=>i.kitap)  
                            .ToList();
                
                */
                    
            
                
                 
            }
            }


        public List<yazar> YazarListHarf(string harf,int id)
        {
            using (var db=new ekitapContext())
            {
                 return db.yazarlar.Where(i=>i.yazarId==id)
                                  //.Where(i=>i.yazarad.StartsWith(harf) && i.yazarId==id)
                                  .Include(i=>i.kitapyazarlar)
                                  .ThenInclude(i=>i.kitap)  
                                  .ToList();
                 
            }
        }


        //--arama kısmında yazar ad-soyad a göre yazar arama:
        public List<yazar> YazarListHarfA(string name)
        {   
           
            using (var db=new ekitapContext())
            {   

                /*
                 return db.yazarlar.Where(i=>i.yazarad==name)
                                  .Include(i=>i.kitapyazarlar)
                                  .ThenInclude(i=>i.kitap)  
                                  .ToList();
                */


            
                Console.WriteLine(name);
                var cmd="SELECT  * from yazarlar as y where (y.yazarad  + ' ' + y.yazarsoyad)={0}";
                return db.yazarlar.FromSqlRaw(cmd,name).ToList();
                        


              
                 
            }
        }






    }
}