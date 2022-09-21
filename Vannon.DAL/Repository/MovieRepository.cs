using Vannon.DataAccess.Context;
using Vannon.Model.Entity;
using Vannon.Model.Interface.Repository;
using System.Linq;

namespace Vannon.DataAccess.Repository
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private VannonCtx _context;

        public MovieRepository()
        {
            _context = new VannonCtx();
        }
        public Movie GetById(int id)
        {
            return _context.Movie.Where(c => c.id == id).FirstOrDefault();
        }
    }
}
