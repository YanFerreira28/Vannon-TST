
using Vannon.Model.Entity;

namespace Vannon.Model.Interface.Service
{
    public interface IMovieService : IBaseService<Movie>
    {
        Movie GetById(int id);
    }
}
