using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Repository
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
        Movie GetById(int id);
    }
}
