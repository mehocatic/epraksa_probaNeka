using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class PraksaConfiguration : IEntityTypeConfiguration<Praksa>
{
    public void Configure(EntityTypeBuilder<Praksa> b)
    {
        b.ToTable("praksa");
        b.HasKey(x => x.IdPraksa);
        b.Property(x => x.IdPraksa).HasColumnName("id_praksa");

        b.Property(x => x.IdKompanija).HasColumnName("id_kompanija");
        b.Property(x => x.Naziv).HasColumnName("naziv").HasMaxLength(150).IsRequired();
        b.Property(x => x.Opis).HasColumnName("opis");
        b.Property(x => x.TrajanjeMjeseci).HasColumnName("trajanje_mjeseci");
        b.Property(x => x.Lokacija).HasColumnName("lokacija").HasMaxLength(100);
        b.Property(x => x.DatumObjave).HasColumnName("datum_objave").HasDefaultValueSql("GETDATE()");
        b.Property(x => x.DatumZavrsetka).HasColumnName("datum_zavrsetka");
        b.Property(x => x.Aktivna).HasColumnName("aktivna");

        b.HasOne(x => x.Kompanija)
            .WithMany(x => x.Prakse)
            .HasForeignKey(x => x.IdKompanija);
    }
}
