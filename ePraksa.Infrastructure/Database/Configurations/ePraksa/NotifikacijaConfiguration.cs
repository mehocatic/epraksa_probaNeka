using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class NotifikacijaConfiguration : IEntityTypeConfiguration<Notifikacija>
{
    public void Configure(EntityTypeBuilder<Notifikacija> b)
    {
        b.ToTable("notifikacija");
        b.HasKey(x => x.IdNotifikacija);

        b.Property(x => x.IdNotifikacija).HasColumnName("id_notifikacija");
        b.Property(x => x.IdKorisnik).HasColumnName("id_korisnik");
        b.Property(x => x.Sadrzaj).HasColumnName("sadrzaj");
        b.Property(x => x.Procitano).HasColumnName("procitano");
        b.Property(x => x.Datum).HasColumnName("datum").HasDefaultValueSql("GETDATE()");

        b.HasOne(x => x.Korisnik)
            .WithMany(x => x.Notifikacije)
            .HasForeignKey(x => x.IdKorisnik)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
