using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Security.Account.Entities;
using SmartVet.Infrastructure.Converters;

namespace SmartVet.Infrastructure.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

             builder.Property(u => u.UserName)
                    .HasMaxLength(256)
                    .IsRequired(false); // Ou IsRequired(), dependendo da sua regra de negócio

            // Para o seu Value Object 'EmailVO' (se você o renomeou para evitar conflito com IdentityUser.Email):
            builder.Property(u => u.UserEmailVO) // Use o nome da sua propriedade do Value Object (ex: EmailVO)
                   .HasConversion<EmailValueConverter>() // Use seu ValueConverter
                   .HasColumnName("CustomEmail") // Dê um nome de coluna único para evitar conflitos
                   .IsRequired(); // Defina como obrigatório ou não

            // Para 'RefreshToken'
            builder.Property(u => u.RefreshToken)
                   .IsRequired(false); // Se for opcional (nullable)



        }
    }
}
