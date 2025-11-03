using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Infrastructure.Database.Configurations.EPraksa;

public class GradConfiguration : IEntityTypeConfiguration<Grad>
{
    public void Configure(EntityTypeBuilder<Grad> b)
    {
        b.ToTable("grad");
        b.HasKey(x => x.IdGrad);
        b.Property(x => x.IdGrad).HasColumnName("id_grad");

        b.Property(x => x.Naziv).HasColumnName("naziv").HasMaxLength(100).IsRequired();
    }
}
