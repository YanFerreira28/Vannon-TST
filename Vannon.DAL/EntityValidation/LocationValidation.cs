using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vannon.Model.Entity;

namespace Vannon.DataAccess.EntityValidation
{
    public class LocationValidation : IEntityTypeConfiguration<Location>
    {

        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Location");
            builder.HasKey(c => c.id);
            builder.Property(c => c.idMovie).IsRequired();
            builder.Property(c => c.valor).IsRequired();
        }
    }
}
