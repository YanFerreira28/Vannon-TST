using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vannon.Model.Entity;

namespace Vannon.DataAccess.EntityValidation
{
    public class MovieValidation : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(c => c.id);
            builder.Property(c => c.titulo).IsRequired().HasMaxLength(100);
            builder.Property(c => c.categoria).IsRequired();
        }
    }
}
