using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using Vannon.Model.Interface.Service;

namespace Vannon.Business.Services
{
    public class LocationService : BaseService<Location>, IBaseService<Location>, ILocationService
    {
        public ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public Location GetById(int id)
        {
            return _locationRepository.GetById(id);
        }
    }
}
