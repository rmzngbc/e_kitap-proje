using ekitap.entity;
using System.Collections.Generic;
namespace ekitap.data.Abstract
{
    public interface IkategoriRepository:IRepository<kategori>
    {
         kategori GetById(int id);

         void deletefromkategori(int kitapId);

        
    }
}