using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Repository
{
    public interface ILocationRepository : IBaseRepository<Location>
    {
        Location GetById(int id);
    }
}
