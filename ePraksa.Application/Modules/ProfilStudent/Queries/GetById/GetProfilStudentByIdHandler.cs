using MediatR;
using Microsoft.EntityFrameworkCore;
using ePraksa.Application.Abstractions;
using ePraksa.Application.Modules.ProfilStudent.DTOs;

namespace ePraksa.Application.Modules.ProfilStudent.Queries.GetById;

public class GetProfilStudentByIdHandler(IAppDbContext db)
    : IRequestHandler<GetProfilStudentByIdQuery, ProfilStudentDto?>
{
    public async Task<ProfilStudentDto?> Handle(GetProfilStudentByIdQuery r, CancellationToken ct)
    {
        return await db.ProfiliStudenata
            .AsNoTracking()
            .Where(p => p.IdProfil == r.IdProfil)
            .Select(p => new ProfilStudentDto
            {
                IdProfil      = p.IdProfil,
                IdKorisnik    = p.IdKorisnik,
                Ime           = p.Ime,
                Prezime       = p.Prezime,
                DatumRodjenja = p.DatumRodjenja,
                Fakultet      = p.Fakultet,
                IdGrad        = p.IdGrad,
                GradNaziv     = p.Grad != null ? p.Grad.Naziv : null,
                Tehnologije   = p.Tehnologije.Select(t => t.Tehnologija.Naziv).ToList(),
                Dokumenti     = p.Dokumenti.Select(d => new ProfilStudentDto.DokumentItem
                {
                    IdDokument = d.IdDokument,
                    Naziv      = d.Naziv
                }).ToList(),
                Obrazovanja = p.Obrazovanja.Select(o => new ProfilStudentDto.ObrazovanjeItem
                {
                    IdObrazovanje = o.IdObrazovanje,
                    Institucija = o.Institucija,
                    Smjer = o.Smjer,
                    NivoStudija = o.NivoStudija,
                    GodinaUpisa = o.GodinaUpisa,
                    GodinaZavrsetka = o.GodinaZavrsetka
                }).ToList()

            })
            .FirstOrDefaultAsync(ct);
    }
}
