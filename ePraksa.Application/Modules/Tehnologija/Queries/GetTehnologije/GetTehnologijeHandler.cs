using MediatR;
using Microsoft.EntityFrameworkCore;
using ePraksa.Application.Abstractions;
using ePraksa.Application.Modules.Tehnologija.DTOs;

namespace ePraksa.Application.Modules.Tehnologija.Queries.GetTehnologije;

public class GetTehnologijeHandler(IAppDbContext db)
    : IRequestHandler<GetTehnologijeQuery, List<TehnologijaDto>>
{
    public async Task<List<TehnologijaDto>> Handle(GetTehnologijeQuery request, CancellationToken ct)
    {
        return await db.Tehnologije
            .AsNoTracking()
            .OrderBy(x => x.Naziv)
            .Select(x => new TehnologijaDto
            {
                IdTehnologija = x.IdTehnologija,
                Naziv = x.Naziv
            })
            .ToListAsync(ct);
    }
}
