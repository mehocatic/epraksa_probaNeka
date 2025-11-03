using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class FavoritPraksaConfiguration : IEntityTypeConfiguration<FavoritPraksa>
{
    public void Configure(EntityTypeBuilder<FavoritPraksa> b)
    {
        b.ToTable("favorit_praksa");
        b.HasKey(x => new { x.IdProfil, x.IdPraksa });

        b.Property(x => x.IdProfil).HasColumnName("id_profil");
        b.Property(x => x.IdPraksa).HasColumnName("id_praksa");
        b.Property(x => x.DatumDodavanja).HasColumnName("datum_dodavanja").HasDefaultValueSql("GETDATE()");

        b.HasOne(x => x.ProfilStudent)
            .WithMany(x => x.Favoriti)
            .HasForeignKey(x => x.IdProfil);

        b.HasOne(x => x.Praksa)
            .WithMany(x => x.Favoriti)
            .HasForeignKey(x => x.IdPraksa);
    }
}
