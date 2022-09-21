using Vannon.DataAccess.Context;
using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using System.Linq;

namespace Vannon.DataAccess.Repository
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        private readonly VannonCtx _context;

        public ClientRepository()
        {
            _context = new VannonCtx();
        }
        public Client GetById(int id)
        {
           return _context.Client.Where(c => c.id == id).FirstOrDefault();
        }
    }
}
