using ekitap.data.Abstract;
using ekitap.entity;

namespace ekitap.data.Concrete.EfCore
{
    public class EfCoreyayineviRepository:EfCoreGenericRepository<yayinevi, ekitapContext>, IyayineviRepository
    {
        
    }
}