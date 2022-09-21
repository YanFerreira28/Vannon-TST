using Vannon.Business.Services;
using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using Vannon.Model.Interface.Service;

namespace Vannon.Business.Services
{
    public class ClientService : BaseService<Client>, IBaseService<Client>, IClientService
    {
        public IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }
    }
}
