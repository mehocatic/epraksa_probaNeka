using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class PraksaTehnologijaConfiguration : IEntityTypeConfiguration<PraksaTehnologija>
{
    public void Configure(EntityTypeBuilder<PraksaTehnologija> b)
    {
        b.ToTable("praksa_tehnologija");
        b.HasKey(x => new { x.IdPraksa, x.IdTehnologija });

        b.Property(x => x.IdPraksa).HasColumnName("id_praksa");
        b.Property(x => x.IdTehnologija).HasColumnName("id_tehnologija");

        b.HasOne(x => x.Praksa)
            .WithMany(x => x.Tehnologije)
            .HasForeignKey(x => x.IdPraksa);

        b.HasOne(x => x.Tehnologija)
            .WithMany(x => x.Prakse)
            .HasForeignKey(x => x.IdTehnologija);
    }
}
