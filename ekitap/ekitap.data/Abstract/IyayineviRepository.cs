using ekitap.entity;

namespace ekitap.data.Abstract
{
    public interface IyayineviRepository:IRepository<yayinevi>
    {
         yayinevi GetById(int id);
         
    }
}