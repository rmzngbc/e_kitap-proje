using System.Collections.Generic;
using ekitap.business.Abstract;
using ekitap.data.Abstract;
using ekitap.data.Concrete.EfCore;
using ekitap.entity;

namespace ekitap.business.Concrete
{
    public class yazarManager:IyazarService
    {
        
         
        private IyazarRepository _yazarRepository;
        public yazarManager(IyazarRepository yazarRepository)
        {
            _yazarRepository = yazarRepository;
        }

        public void Create(yazar entity)
        {
            
            _yazarRepository.Create(entity);
        }

        public List<yazar> GetAll()
        {
            return _yazarRepository.GetAll();
        }

        public yazar GetById(int Id)
        {
            return _yazarRepository.GetById(Id);
        }

        public void Update(yazar entity)
        {
             _yazarRepository.Update(entity);
        }

        public List<yazar> YazarListHarf(string harf)
        {
            return _yazarRepository.YazarListHarf(harf);
        }

        public List<yazar> YazarListHarf(string harf,int id)
        {
            return _yazarRepository.YazarListHarf(harf,id);
        }

        public List<yazar> YazarListHarfA(string name)
        {
            return _yazarRepository.YazarListHarfA(name);
        }

       





    }
}