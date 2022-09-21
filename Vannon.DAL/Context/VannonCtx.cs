
using Microsoft.EntityFrameworkCore;
using Vannon.DataAccess.EntityValidation;
using Vannon.Model.Entity;

namespace Vannon.DataAccess.Context
{
    public class VannonCtx : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Vannon;
Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientValidation());
            modelBuilder.ApplyConfiguration(new LocationValidation());
            modelBuilder.ApplyConfiguration(new MovieValidation());
            modelBuilder.ApplyConfiguration(new UserValidation());

            base.OnModelCreating(modelBuilder);

        }


        public DbSet<Client> Client { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> User { get; set; }

    }
}
