using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class StudentObrazovanjeConfiguration : IEntityTypeConfiguration<StudentObrazovanje>
{
    public void Configure(EntityTypeBuilder<StudentObrazovanje> b)
    {
        b.ToTable("student_obrazovanje");
        b.HasKey(x => x.IdObrazovanje);
        b.Property(x => x.IdObrazovanje).HasColumnName("id_obrazovanje");

        b.Property(x => x.IdProfil).HasColumnName("id_profil");
        b.Property(x => x.Institucija).HasColumnName("institucija").HasMaxLength(150).IsRequired();
        b.Property(x => x.Smjer).HasColumnName("smjer").HasMaxLength(100);
        b.Property(x => x.NivoStudija).HasColumnName("nivo_studija").HasMaxLength(50);
        b.Property(x => x.GodinaUpisa).HasColumnName("godina_upisa");
        b.Property(x => x.GodinaZavrsetka).HasColumnName("godina_zavrsetka");

        b.HasOne(x => x.ProfilStudent)
            .WithMany(x => x.Obrazovanja)
            .HasForeignKey(x => x.IdProfil)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
