using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class ProfilKompanijaConfiguration : IEntityTypeConfiguration<ProfilKompanija>
{
    public void Configure(EntityTypeBuilder<ProfilKompanija> b)
    {
        b.ToTable("profil_kompanija");
        b.HasKey(x => x.IdProfil);
        b.Property(x => x.IdProfil).HasColumnName("id_profil");

        b.Property(x => x.IdKorisnik).HasColumnName("id_korisnik");
        b.Property(x => x.Naziv).HasColumnName("naziv").HasMaxLength(150).IsRequired();
        b.Property(x => x.Opis).HasColumnName("opis");
        b.Property(x => x.WebStranica).HasColumnName("web_stranica").HasMaxLength(150);
        b.Property(x => x.IdGrad).HasColumnName("id_grad");

        b.HasOne(x => x.Korisnik)
            .WithMany(x => x.ProfiliKompanije)
            .HasForeignKey(x => x.IdKorisnik)
            .OnDelete(DeleteBehavior.Cascade);

        b.HasOne(x => x.Grad)
            .WithMany(x => x.ProfiliKompanije)
            .HasForeignKey(x => x.IdGrad)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
