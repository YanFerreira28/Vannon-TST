
using Vannon.Model.Enum;

namespace Vannon.Model.Entity
{
    public class Movie
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public Categoria categoria { get; set; }

    }
}
