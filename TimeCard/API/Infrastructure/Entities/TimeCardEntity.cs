using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeCard.API.Model;

namespace TimeCard.API.Infrastructure.Entities
{
    public class TimeCardEntity : IEntityTypeConfiguration<TimeCards>
    {
        public void Configure(EntityTypeBuilder<TimeCards> builder)
        {
            builder.ToTable("TimeCards");

            builder.HasKey(ci => ci.ID);

            builder.Property(ci => ci.ID)
               .UseHiLo("time_card_hilo")
               .IsRequired();
        }
    }
}
