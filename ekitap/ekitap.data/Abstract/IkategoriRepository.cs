using ekitap.entity;
namespace ekitap.data.Abstract
{
    public interface IkategoriRepository:IRepository<kategori>
    {
         kategori GetById(int id);

         void deletefromkategori(int kitapId);
    }
}