using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vannon.Model.Entity;

namespace Vannon.DataAccess.EntityValidation
{
    public class ClientValidation : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(c => c.id);
            builder.Property(c => c.idLocation).IsRequired();
            builder.Property(c => c.idUser).IsRequired();
        }
    }
}
