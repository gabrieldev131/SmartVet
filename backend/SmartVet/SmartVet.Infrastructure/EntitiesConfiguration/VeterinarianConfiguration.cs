using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.EntitiesConfiguration
{
    public class VeterinarianConfiguration : IEntityTypeConfiguration<Veterinarian>
    {
        public void Configure(EntityTypeBuilder<Veterinarian> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasMany<Apointment>(veterinarian => veterinarian.Apointments)
                .WithOne(apointment => apointment.Veterinarian)
                .HasForeignKey(veterinarian => veterinarian.ApointmentVeterinarianId);


        }
    }
}
