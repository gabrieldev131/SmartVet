using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartVet.Domain.Entities;

namespace SmartVet.Infrastructure.EntitiesConfiguration
{
    public class GenericUserConfiguration : IEntityTypeConfiguration<GenericUser>
    {
        public void Configure(EntityTypeBuilder<GenericUser> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
