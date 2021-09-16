using System.Collections.Generic;
using ekitap.entity;

namespace ekitap.business.Abstract
{
    public interface IkategoriService
    {
        List<kategori> GetAll();

        void Create(kategori entity);

        void Update(kategori entity);
        void Delete(kategori entity);

        kategori GetById(int id);

        void deletefromkategori(int kitapId);
    }
}