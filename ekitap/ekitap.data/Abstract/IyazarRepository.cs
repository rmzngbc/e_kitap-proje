using ekitap.entity;
using System.Collections.Generic;

namespace ekitap.data.Abstract
{
    public interface IyazarRepository:IRepository<yazar>
    {
        
        yazar GetById(int Id);

        List<yazar> YazarListHarf(string harf);

        List<yazar> YazarListHarf(string harf,int id);

         
    }
}