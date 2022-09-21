using Vannon.DataAccess.Repository;
using Vannon.Model.Interface.Repository;
using Vannon.Model.Interface.Service;
using System.Collections.Generic;

namespace Vannon.Business.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService()
        {
            _baseRepository = new BaseRepository<T>();
        }

        public void Delete(T data)
        {
            _baseRepository.Delete(data);
        }

        public IList<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public void Insert(T data)
        {
            _baseRepository.Insert(data);
        }

        public void Update(T data)
        {
            _baseRepository.Update(data);
        }
    }
}
