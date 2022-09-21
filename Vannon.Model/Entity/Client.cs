
namespace Vannon.Model.Entity
{
    public class Client
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public int idLocation { get; set; }

        public virtual User user { get; set; }
        public virtual Location location { get; set; }
    }
}
