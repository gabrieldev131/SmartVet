using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.EntitiesConfiguration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany<Apointment>(animal => animal.Apointments)
                .WithOne(apointment => apointment.Animal)
                .HasForeignKey(animal => animal.ApointmentAnimalId);


        }
    }
}
