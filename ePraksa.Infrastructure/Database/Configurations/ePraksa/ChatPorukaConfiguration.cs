using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class ChatPorukaConfiguration : IEntityTypeConfiguration<ChatPoruka>
{
    public void Configure(EntityTypeBuilder<ChatPoruka> b)
    {
        b.ToTable("chat_poruka");
        b.HasKey(x => x.IdPoruka);

        b.Property(x => x.IdPoruka).HasColumnName("id_poruka");
        b.Property(x => x.IdPosiljalac).HasColumnName("id_posiljalac");
        b.Property(x => x.IdPrimalac).HasColumnName("id_primalac");
        b.Property(x => x.Sadrzaj).HasColumnName("sadrzaj");
        b.Property(x => x.DatumSlanja).HasColumnName("datum_slanja").HasDefaultValueSql("GETDATE()");
        b.Property(x => x.Procitana).HasColumnName("procitana");

        b.HasOne(x => x.Posiljalac)
            .WithMany(x => x.PoslanePoruke)
            .HasForeignKey(x => x.IdPosiljalac)
            .OnDelete(DeleteBehavior.NoAction);

        b.HasOne(x => x.Primalac)
            .WithMany(x => x.PrimljenePoruke)
            .HasForeignKey(x => x.IdPrimalac)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
