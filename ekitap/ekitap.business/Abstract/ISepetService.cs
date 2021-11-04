using ekitap.entity;

namespace ekitap.business.Abstract
{
    public interface ISepetService
    {
         void InitializeSepet(string userId);

         Sepet GetSepetByUserId(string userId);

         //--sepete kitap ekleme:
         void AddToSepet(string userId,int kitapId,int adet);

         void DeleteFromSepet(string userId,int kitapId);

         void UpdateToSepet(string userId,int SepetItemId,int kitapId,int adet);
    }
}