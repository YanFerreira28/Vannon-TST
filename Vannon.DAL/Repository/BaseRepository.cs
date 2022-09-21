using Vannon.DataAccess.Context;
using Vannon.Model.Interface.Repository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Vannon.DataAccess.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
    {
        private VannonCtx _context;

        public BaseRepository()
        {
            _context = new VannonCtx();
        }

        public void Delete(T data)
        {
            _context.Set<T>().Remove(data);
            _context.SaveChanges();
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }


        public void Insert(T data)
        {
            _context.Set<T>().Add(data);
            _context.SaveChanges();
        }

        public void Update(T data)
        {
            _context.Entry<T>(data).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
