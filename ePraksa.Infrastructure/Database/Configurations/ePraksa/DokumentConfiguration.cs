using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class DokumentConfiguration : IEntityTypeConfiguration<Dokument>
{
    public void Configure(EntityTypeBuilder<Dokument> b)
    {
        b.ToTable("dokument");
        b.HasKey(x => x.IdDokument);
        b.Property(x => x.IdDokument).HasColumnName("id_dokument");

        b.Property(x => x.IdProfil).HasColumnName("id_profil");
        b.Property(x => x.Naziv).HasColumnName("naziv").HasMaxLength(150).IsRequired();
        b.Property(x => x.Putanja).HasColumnName("putanja").HasMaxLength(255).IsRequired();
        b.Property(x => x.DatumUpload).HasColumnName("datum_upload").HasDefaultValueSql("GETDATE()");

        b.HasOne(x => x.ProfilStudent)
            .WithMany(x => x.Dokumenti)
            .HasForeignKey(x => x.IdProfil);
    }
}
