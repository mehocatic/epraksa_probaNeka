using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class TehnologijaConfiguration : IEntityTypeConfiguration<Tehnologija>
{
    public void Configure(EntityTypeBuilder<Tehnologija> b)
    {
        b.ToTable("tehnologija");
        b.HasKey(x => x.IdTehnologija);
        b.Property(x => x.IdTehnologija).HasColumnName("id_tehnologija");

        b.Property(x => x.Naziv).HasColumnName("naziv").HasMaxLength(100).IsRequired();
    }
}
