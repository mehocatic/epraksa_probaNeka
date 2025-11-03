using ePraksa.Domain.Entities.EPraksa;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ePraksa.Application.Abstractions;

public interface IAppDbContext
{
    DbSet<Korisnik> Korisnici { get; }
    DbSet<Grad> Gradovi { get; }
    DbSet<ProfilStudent> ProfiliStudenata { get; }
    DbSet<StudentObrazovanje> StudentObrazovanja { get; }
    DbSet<Tehnologija> Tehnologije { get; }
    DbSet<StudentTehnologija> StudentTehnologije { get; }
    DbSet<Dokument> Dokumenti { get; }
    DbSet<ProfilKompanija> ProfiliKompanije { get; }
    DbSet<Praksa> Prakse { get; }
    DbSet<PraksaTehnologija> PraksaTehnologije { get; }
    DbSet<StatusPrijave> StatusiPrijave { get; }
    DbSet<StudentPraksa> StudentPrakse { get; }
    DbSet<FavoritPraksa> FavoritiPraksa { get; }
    DbSet<Review> Reviews { get; }
    DbSet<ChatPoruka> ChatPoruke { get; }
    DbSet<Notifikacija> Notifikacije { get; }

    Task<int> SaveChangesAsync(CancellationToken ct);
}
