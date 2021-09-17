using System.Collections.Generic;
using ekitap.business.Abstract;
using ekitap.data.Abstract;
using ekitap.data.Concrete.EfCore;
using ekitap.entity;


namespace ekitap.business.Concrete
{
    public class kitapManager:IkitapService
    {
        private IkitapRepository _kitapRepository;
        public kitapManager(IkitapRepository kitapRepository)
        {
            _kitapRepository = kitapRepository;
        }

         public void Create(kitap entity)
        {
            // iş kuralları uygula
            _kitapRepository.Create(entity);
        }

        public void Delete(kitap entity)
        {
            // iş kuralları
            _kitapRepository.Delete(entity);
        }

        public List<kitap> GetAll()
        {            
            return _kitapRepository.GetAll();
        }

        public void Update(kitap entity)
        {
           _kitapRepository.Update(entity);
        }

        public kitap GetById(int id)
        {
            return _kitapRepository.GetById(id);
        }

        public List<kitap> GetkitapBykategori(string kategoriad,int page,int pageSize)
        {
            return _kitapRepository.GetkitapBykategori(kategoriad,page,pageSize);
        }

        public kitap GetkitapDetails(string url)
        {
            return _kitapRepository.GetkitapDetails(url);
        }

        public int GetCountByCategory(string category)
        {
            return _kitapRepository.GetCountByCategory(category);
        }

        public List<kitap> GetHomePagekitaplar(string kategoriad,int page,int pageSize)
        {
            return _kitapRepository.GetHomePagekitaplar(kategoriad,page,pageSize);
        }

        public List<kitap> KitapAra(string KelimeAra)
        {
            return _kitapRepository.KitapAra(KelimeAra);
        }

        public void Create(kitap entity,int[] yazarIds)
        {
             _kitapRepository.Create(entity,yazarIds);
        }

      
        
    }
}