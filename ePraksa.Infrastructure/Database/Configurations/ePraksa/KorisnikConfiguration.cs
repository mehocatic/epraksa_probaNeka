using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class KorisnikConfiguration : IEntityTypeConfiguration<Korisnik>
{
    public void Configure(EntityTypeBuilder<Korisnik> b)
    {
        b.ToTable("korisnik");
        b.HasKey(x => x.IdKorisnik);
        b.Property(x => x.IdKorisnik).HasColumnName("id_korisnik");

        b.Property(x => x.Email).HasColumnName("email").HasMaxLength(100).IsRequired();
        b.Property(x => x.Lozinka).HasColumnName("lozinka").HasMaxLength(255).IsRequired();
        b.Property(x => x.DatumRegistracije).HasColumnName("datum_registracije").HasDefaultValueSql("GETDATE()");
        b.Property(x => x.TipKorisnika).HasColumnName("tip_korisnika").HasMaxLength(20).IsRequired();
        b.Property(x => x.Aktivna).HasColumnName("aktivna");
    }
}
