using Vannon.DataAccess.Context;
using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using System.Linq;

namespace Vannon.DataAccess.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private VannonCtx _context;

        public UserRepository()
        {
            _context = new VannonCtx();
        }

        public User GetById(int id)
        {
            return _context.User.Where(c => c.id == id).FirstOrDefault();
        }
    }
}
