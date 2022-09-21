
using System.Collections.Generic;

namespace Vannon.Model.Interface.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Insert(T data);
        void Delete(T data);
        void Update(T data);
        IList<T> GetAll();
    }
}
