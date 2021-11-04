using ekitap.entity;

namespace ekitap.data.Abstract
{
    public interface ISepetRepository:IRepository<Sepet>
    {
        
        Sepet GetByUserId(string userId);

        void DeleteFromSepet(int sepetId,int kitapId);
         
    }
}