using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class StudentPraksaConfiguration : IEntityTypeConfiguration<StudentPraksa>
{
    public void Configure(EntityTypeBuilder<StudentPraksa> b)
    {
        b.ToTable("student_praksa");
        b.HasKey(x => x.IdStudentPraksa);

        b.Property(x => x.IdStudentPraksa).HasColumnName("id_student_praksa");
        b.Property(x => x.IdProfil).HasColumnName("id_profil");
        b.Property(x => x.IdPraksa).HasColumnName("id_praksa");
        b.Property(x => x.DatumPrijave).HasColumnName("datum_prijave").HasDefaultValueSql("GETDATE()");
        b.Property(x => x.IdStatus).HasColumnName("id_status");
        b.Property(x => x.MotivacionoPismo).HasColumnName("motivaciono_pismo");

        b.HasOne(x => x.ProfilStudent)
            .WithMany(x => x.PrijaveNaPrakse)
            .HasForeignKey(x => x.IdProfil);

        b.HasOne(x => x.Praksa)
            .WithMany(x => x.PrijaveStudenata)
            .HasForeignKey(x => x.IdPraksa);

        b.HasOne(x => x.StatusPrijave)
            .WithMany(x => x.PrijaveStudenata)
            .HasForeignKey(x => x.IdStatus)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
