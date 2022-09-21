using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using Vannon.Model.Interface.Service;

namespace Vannon.Business.Services
{
    public class MovieService : BaseService<Movie>, IBaseService<Movie>, IMovieService
    {
        public IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }
    }
}
