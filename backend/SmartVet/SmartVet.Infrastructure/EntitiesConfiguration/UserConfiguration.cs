using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Security.Account.Entities;

namespace SmartVet.Infrastructure.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Email, email =>
            {
                email.OwnsOne(e => e.Verification);
            });
            builder.OwnsOne(x => x.Password);


        }
    }
}

//builder.OwnsOne(x => x.Email, email =>
//{
//    email.Property(e => e.Address)
//        .HasColumnName("Email")
//        .IsRequired();

//    email.OwnsOne(e => e.Verification, verification =>
//    {
//        verification.Property(v => v.Code)
//            .HasColumnName("EmailVerificationCode")
//            .IsRequired();

//        verification.Property(v => v.ExpiresAt)
//            .HasColumnName("EmailVerificationExpiresAt");

//        verification.Property(v => v.VerifiedAt)
//            .HasColumnName("EmailVerificationVerifiedAt");

//        verification.Ignore(v => v.IsActive); // Computado, não precisa no banco
//    });
//});