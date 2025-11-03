using MediatR;
using Microsoft.EntityFrameworkCore;
using ePraksa.Application.Abstractions;
using ePraksa.Domain.Entities.EPraksa;

namespace ePraksa.Application.Modules.ProfilStudent.Commands.Create;

public class CreateProfilStudentHandler(IAppDbContext ctx)
    : IRequestHandler<CreateProfilStudentCommand, int>
{
    public async Task<int> Handle(CreateProfilStudentCommand r, CancellationToken ct)
    {
        // 1) FK validacije
        var korisnikExists = await ctx.Korisnici.AnyAsync(k => k.IdKorisnik == r.Body.IdKorisnik, ct);
        if (!korisnikExists)
            throw new InvalidOperationException("Korisnik ne postoji.");

        if (r.Body.IdGrad is not null)
        {
            var gradExists = await ctx.Gradovi.AnyAsync(g => g.IdGrad == r.Body.IdGrad, ct);
            if (!gradExists)
                throw new InvalidOperationException("Grad ne postoji.");
        }

        // 2) Jedinstvenost profila po korisniku
        var vecPostoji = await ctx.ProfiliStudenata.AnyAsync(p => p.IdKorisnik == r.Body.IdKorisnik, ct);
        if (vecPostoji)
            throw new InvalidOperationException("Profil za ovog korisnika već postoji.");

        // 3) Kreiranje entiteta
        var entity = new ePraksa.Domain.Entities.EPraksa.ProfilStudent

        {
            IdKorisnik = r.Body.IdKorisnik,
            Ime = r.Body.Ime,
            Prezime = r.Body.Prezime,
            DatumRodjenja = r.Body.DatumRodjenja,
            Fakultet = r.Body.Fakultet,
            IdGrad = r.Body.IdGrad
        };

        ctx.ProfiliStudenata.Add(entity);
        await ctx.SaveChangesAsync(ct);

        return entity.IdProfil;
    }

}
