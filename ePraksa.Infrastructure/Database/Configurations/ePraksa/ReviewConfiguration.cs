using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> b)
    {
        b.ToTable("review");
        b.HasKey(x => x.IdReview);

        b.Property(x => x.IdReview).HasColumnName("id_review");
        b.Property(x => x.IdStudentPraksa).HasColumnName("id_student_praksa");
        b.Property(x => x.Ocjena).HasColumnName("ocjena");
        b.Property(x => x.Komentar).HasColumnName("komentar");
        b.Property(x => x.Datum).HasColumnName("datum").HasDefaultValueSql("GETDATE()");

        b.HasOne(x => x.StudentPraksa)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.IdStudentPraksa)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
