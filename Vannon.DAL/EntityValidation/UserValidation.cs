using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vannon.Model.Entity;

namespace Vannon.DataAccess.EntityValidation
{
    public class UserValidation : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(c => c.id);
            builder.Property(c => c.cpf).IsRequired().HasMaxLength(11);
            builder.Property(c => c.estado).IsRequired().HasMaxLength(2);
            builder.Property(c => c.email).IsRequired().HasMaxLength(150);
            builder.Property(c => c.endereco).IsRequired().HasMaxLength(150);
            builder.Property(c => c.nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.telefone).IsRequired().HasMaxLength(22);
        }
    }
}
