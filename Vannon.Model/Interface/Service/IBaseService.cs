using System.Collections.Generic;

namespace Vannon.Model.Interface.Service
{
    public interface IBaseService<T> where T:class
    {
        void Insert(T data);
        void Delete(T data);
        void Update(T data);
        IList<T> GetAll();
    }
}
