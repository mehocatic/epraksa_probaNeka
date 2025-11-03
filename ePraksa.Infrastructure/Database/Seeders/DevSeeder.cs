using Microsoft.EntityFrameworkCore;
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
        
        //await SeedStatusPrijave();
        await SeedTehnologije();
        await SeedTehnologije();

        await _db.SaveChangesAsync();
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

            await _db.SaveChangesAsync();
        }
    }


    //private async Task SeedStatusPrijave()
    //{
    //    if (!await _db.StatusPrijave.AnyAsync())
    //    {
    //        _db.StatusPrijave.AddRange(
    //            new() { Naziv = "U toku" },
    //            new() { Naziv = "Prihvaćeno" },
    //            new() { Naziv = "Odbijeno" }
    //        );
    //    }
    //}

}
