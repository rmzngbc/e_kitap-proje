using System.Collections.Generic;
using ekitap.business.Abstract;
using ekitap.data.Abstract;
using ekitap.entity;

namespace ekitap.business.Concrete
{
    public class yayineviManager:IyayineviService
    {
        private IyayineviRepository _yayineviRepository;
        public yayineviManager(IyayineviRepository yayineviRepository)
        {
            _yayineviRepository = yayineviRepository;
        }

        public void Create(yayinevi entity)
        {
            _yayineviRepository.Create(entity);
        }

        //--bütün yayinevlerini listeleme:

        public List<yayinevi> GetAll()
        {            
            return _yayineviRepository.GetAll();
        }
    }
}