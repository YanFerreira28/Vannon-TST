
using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Service
{
    public interface ILocationService : IBaseService<Location>
    {
        Location GetById(int id);
    }
}
