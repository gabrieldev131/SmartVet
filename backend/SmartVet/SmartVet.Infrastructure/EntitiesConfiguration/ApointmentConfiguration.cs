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
              .HasMany<Service>(apointment => apointment.Services);


        }
    }
}
