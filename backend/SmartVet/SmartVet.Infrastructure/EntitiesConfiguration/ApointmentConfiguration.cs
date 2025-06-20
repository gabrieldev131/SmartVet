using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.EntitiesConfiguration
{
    public class ApointmentConfiguration : IEntityTypeConfiguration<Apointment>
    {
        public void Configure(EntityTypeBuilder<Apointment> builder)
        {
            builder.HasKey(x => x.Id);


            builder
                .HasOne<Animal>(apointment => apointment.Animal)
                .WithMany(animal => animal.Apointments)
                .HasForeignKey(apointment => apointment.ApointmentAnimalId);

        }
    }
}
