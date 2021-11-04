using System;
using System.Linq;
using ekitap.business.Abstract;
using ekitap.data.Abstract;
using ekitap.entity;

namespace ekitap.business.Concrete
{   
    



    //arabirimi uygulama: ctrl+. ile
    public class SepetManager : ISepetService

    {

        private ISepetRepository _sepetRepository;
        public SepetManager(ISepetRepository sepetRepository)
        {
            _sepetRepository=sepetRepository;
        }

        //--sepete kitap ekleme:
        public void AddToSepet(string userId,int kitapId,int adet)
        {
            var sepet=GetSepetByUserId(userId);

            if (sepet!=null)
            {
                var index=sepet.SepetItems.FindIndex(i=>i.kitapId==kitapId);

                if (index<0)
                {   
                    //eğet sepette kitap ıd yoksa yeni bir identity oluştur:
                    sepet.SepetItems.Add(new SepetItem(){
                        kitapId=kitapId,
                        Adet=adet,
                        SepetId=sepet.Id

                    });
                    
                }
                else
                {   
                    //eğer sepette aynı kitapid var ise,adet miktarınıa artır
                    sepet.SepetItems[index].Adet+=adet;
                }

                //bütün ekleme işlemlerinden sonra sepet i güncelle:
                _sepetRepository.Update(sepet);
                
            }

        }

        public void DeleteFromSepet(string userId, int kitapId)
        {
            var sepet=GetSepetByUserId(userId);
            if (sepet!=null)
            {
                _sepetRepository.DeleteFromSepet(sepet.Id,kitapId);
                
            }
        }

        public Sepet GetSepetByUserId(string userId)
        {
            return _sepetRepository.GetByUserId(userId);
        }

        public void InitializeSepet(string userId)
        {
            _sepetRepository.Create(new Sepet(){UserId=userId});
        }

        public void UpdateToSepet(string userId,int SepetItemId ,int kitapId, int adet)
        {

            //--userId ye göre sepet bilgilerini alalım:    
            var sepet=GetSepetByUserId(userId);
            
            Console.WriteLine(userId);
            Console.WriteLine(SepetItemId);
            Console.WriteLine(kitapId);
            Console.WriteLine(adet);
            
            foreach (var item in sepet.SepetItems)
            { 
                

                if (item.SepetId==SepetItemId && item.kitapId==kitapId)
                {
                    item.Adet=adet;
                   
                    
                }
            }
            

            _sepetRepository.Update(sepet);
        }
    }
}