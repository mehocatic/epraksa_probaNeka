using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class ProfilStudentConfiguration : IEntityTypeConfiguration<ProfilStudent>
{
    public void Configure(EntityTypeBuilder<ProfilStudent> b)
    {
        b.ToTable("profil_student");
        b.HasKey(x => x.IdProfil);
        b.Property(x => x.IdProfil).HasColumnName("id_profil");

        b.Property(x => x.IdKorisnik).HasColumnName("id_korisnik");
        b.Property(x => x.Ime).HasColumnName("ime").HasMaxLength(100).IsRequired();
        b.Property(x => x.Prezime).HasColumnName("prezime").HasMaxLength(100).IsRequired();
        b.Property(x => x.DatumRodjenja).HasColumnName("datum_rodjenja");
        b.Property(x => x.Fakultet).HasColumnName("fakultet").HasMaxLength(150);
        b.Property(x => x.IdGrad).HasColumnName("id_grad");

        b.HasOne(x => x.Korisnik)
            .WithMany(x => x.ProfiliStudenta)
            .HasForeignKey(x => x.IdKorisnik)
            .OnDelete(DeleteBehavior.Cascade);

        b.HasOne(x => x.Grad)
            .WithMany(x => x.ProfiliStudenta)
            .HasForeignKey(x => x.IdGrad)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
