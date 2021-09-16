using System.Collections.Generic;
using ekitap.business.Abstract;
using ekitap.data.Abstract;
using ekitap.data.Concrete.EfCore;
using ekitap.entity;


namespace ekitap.business.Concrete
{
    public class kategoriManager:IkategoriService
    {

        private IkategoriRepository _kategoriRepository;
        public kategoriManager(IkategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }

         public void Create(kategori entity)
        {
            // iş kuralları uygula
            _kategoriRepository.Create(entity);
        }

        public void Delete(kategori entity)
        {
            // iş kuralları
            _kategoriRepository.Delete(entity);
        }

        public List<kategori> GetAll()
        {            
            return _kategoriRepository.GetAll();
        }

        public void Update(kategori entity)
        {
             _kategoriRepository.Update(entity);
        }

        public kategori GetById(int id)
        {            
            return _kategoriRepository.GetById(id);
        }

         public void deletefromkategori(int kitapId)
        {            
             _kategoriRepository.deletefromkategori(kitapId);
        }
        

        
    }
}