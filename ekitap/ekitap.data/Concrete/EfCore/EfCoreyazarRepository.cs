using System.Collections.Generic;
using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;

namespace ekitap.data.Concrete.EfCore
{
    public class EfCoreyazarRepository:EfCoreGenericRepository<yazar, ekitapContext>, IyazarRepository
    {
        
    }
}