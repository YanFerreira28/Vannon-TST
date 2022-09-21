using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Repository
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        Client GetById(int id);
    }
}
