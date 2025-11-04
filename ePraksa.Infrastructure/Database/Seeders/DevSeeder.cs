using Microsoft.EntityFrameworkCore;
using ePraksa.Domain.Entities.EPraksa; // <-- bitno da imaš EPraksa namespace
using ePraksa.Domain.Entities;
namespace ePraksa.Infrastructure.Database;

public class DevSeeder
{
    private readonly DatabaseContext _db;

    public DevSeeder(DatabaseContext db)
    {
        _db = db;
    }

    public async Task Seed()
    {
        await SeedKorisnici();
        await SeedGradovi();
        await SeedTehnologije();

        await _db.SaveChangesAsync();
    }

    private async Task SeedKorisnici()
    {
        if (!await _db.Korisnici.AnyAsync())
        {
            _db.Korisnici.AddRange(
                new Korisnik { Email = "student@test.com", Lozinka = "123", TipKorisnika = "student", Aktivna = true },
                new Korisnik { Email = "firma@test.com", Lozinka = "123", TipKorisnika = "kompanija", Aktivna = true },
                new Korisnik { Email = "admin@test.com", Lozinka = "admin", TipKorisnika = "admin", Aktivna = true }
            );
        }
    }

    private async Task SeedGradovi()
    {
        if (!await _db.Gradovi.AnyAsync())
        {
            _db.Gradovi.AddRange(
                new() { Naziv = "Mostar" },
                new() { Naziv = "Sarajevo" },
                new() { Naziv = "Tuzla" },
                new() { Naziv = "Zenica" },
                new() { Naziv = "Banja Luka" }
            );
        }
    }

    private async Task SeedTehnologije()
    {
        var defaultTehnologije = new List<string>
        {
            "C#",
            "ASP.NET",
            "Angular",
            "React",
            "JavaScript",
            "SQL",
            "Python",
            "Java"
        };

        var existing = await _db.Tehnologije
            .Select(x => x.Naziv)
            .ToListAsync();

        var toAdd = defaultTehnologije
            .Except(existing, StringComparer.OrdinalIgnoreCase)
            .ToList();

        if (toAdd.Any())
        {
            foreach (var naziv in toAdd)
                _db.Tehnologije.Add(new() { Naziv = naziv });
        }
    }
}
