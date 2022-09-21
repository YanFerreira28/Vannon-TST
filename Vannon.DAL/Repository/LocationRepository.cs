using Vannon.DataAccess.Context;
using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using System.Linq;

namespace Vannon.DataAccess.Repository
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        private VannonCtx _context;

        public LocationRepository()
        {
            _context = new VannonCtx();
        }
        public Location GetById(int id)
        {
            return _context.Location.Where(c => c.id == id).FirstOrDefault();
        }
    }
}
