
using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Service
{
    public interface IClientService : IBaseService<Client>
    {
        Client GetById(int id);
    }
}
