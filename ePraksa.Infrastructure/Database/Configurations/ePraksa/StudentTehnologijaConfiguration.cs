using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class StudentTehnologijaConfiguration : IEntityTypeConfiguration<StudentTehnologija>
{
    public void Configure(EntityTypeBuilder<StudentTehnologija> b)
    {
        b.ToTable("student_tehnologija");
        b.HasKey(x => new { x.IdProfil, x.IdTehnologija });

        b.Property(x => x.IdProfil).HasColumnName("id_profil");
        b.Property(x => x.IdTehnologija).HasColumnName("id_tehnologija");

        b.HasOne(x => x.ProfilStudent)
            .WithMany(x => x.Tehnologije)
            .HasForeignKey(x => x.IdProfil);

        b.HasOne(x => x.Tehnologija)
            .WithMany(x => x.Studenti)
            .HasForeignKey(x => x.IdTehnologija);
    }
}
