using System.Collections.Generic;
using ekitap.entity;

namespace ekitap.business.Abstract
{
    public interface IyazarService
    {
         void Create(yazar entity);

         List<yazar> GetAll();

         yazar GetById(int Id);

         void Update(yazar entiy);
    }
}