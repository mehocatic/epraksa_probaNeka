using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class StatusPrijaveConfiguration : IEntityTypeConfiguration<StatusPrijave>
{
    public void Configure(EntityTypeBuilder<StatusPrijave> b)
    {
        b.ToTable("status_prijave");
        b.HasKey(x => x.IdStatus);
        b.Property(x => x.IdStatus).HasColumnName("id_status");

        b.Property(x => x.Naziv).HasColumnName("naziv").HasMaxLength(50).IsRequired();
    }
}
