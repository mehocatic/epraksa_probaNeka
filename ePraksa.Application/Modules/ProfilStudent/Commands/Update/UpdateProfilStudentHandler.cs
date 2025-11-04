using MediatR;
using Microsoft.EntityFrameworkCore;
using ePraksa.Application.Abstractions;

namespace ePraksa.Application.Modules.ProfilStudent.Commands.Update;

public class UpdateProfilStudentHandler(IAppDbContext db)
    : IRequestHandler<UpdateProfilStudentCommand>
{
    public async Task Handle(UpdateProfilStudentCommand r, CancellationToken ct)
    {
        var entity = await db.ProfiliStudenata
            .FirstOrDefaultAsync(p => p.IdProfil == r.IdProfil, ct);

        if (entity == null)
            throw new InvalidOperationException("Profil ne postoji.");

        entity.Ime = r.Body.Ime;
        entity.Prezime = r.Body.Prezime;
        entity.DatumRodjenja = r.Body.DatumRodjenja;
        entity.Fakultet = r.Body.Fakultet;
        entity.IdGrad = r.Body.IdGrad;

        await db.SaveChangesAsync(ct);
    }
}
