using System.Collections.Generic;
using ekitap.entity;

namespace ekitap.business.Abstract
{
    public interface IyayineviService
    {
         List<yayinevi> GetAll();

          void Create(yayinevi entity);
    }
}