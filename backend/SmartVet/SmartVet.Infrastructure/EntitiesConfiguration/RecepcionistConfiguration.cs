using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.EntitiesConfiguration
{
    public class RecepcionistConfiguration : IEntityTypeConfiguration<Recepcionist>
    {
        public void Configure(EntityTypeBuilder<Recepcionist> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
