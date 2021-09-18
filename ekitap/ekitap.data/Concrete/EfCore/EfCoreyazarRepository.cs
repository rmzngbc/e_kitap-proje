using System.Collections.Generic;
using System.Linq;
using ekitap.data.Abstract;
using ekitap.entity;
using Microsoft.EntityFrameworkCore;

namespace ekitap.data.Concrete.EfCore
{
    public class EfCoreyazarRepository:EfCoreGenericRepository<yazar, ekitapContext>, IyazarRepository
    {
        public yazar GetById(int Id)
        {
            using (var db=new ekitapContext())
            {
                return db.yazarlar.Where(i=>i.yazarId==Id).FirstOrDefault();
                 
            }

        }
    }
}