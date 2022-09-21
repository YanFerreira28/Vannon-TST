
namespace Vannon.Model.Entity
{
    public class Location
    {
        public int id { get; set; }
        public int idMovie { get; set; }
        public string dataDevolucao { get; set; }
        public decimal valor { get; set; }

        public virtual Movie movie { get; set; }

    }
}
