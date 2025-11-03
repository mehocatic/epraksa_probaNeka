using MediatR;
using Microsoft.EntityFrameworkCore;
using ePraksa.Application.Abstractions;
using ePraksa.Application.Modules.Grad.Dtos;

namespace ePraksa.Application.Modules.Grad.Queries.GetGradovi;

public class GetGradoviHandler(IAppDbContext ctx) : IRequestHandler<GetGradoviQuery, List<GradDto>>
{
    public async Task<List<GradDto>> Handle(GetGradoviQuery request, CancellationToken ct)
    {
        return await ctx.Gradovi
            .AsNoTracking()
            .OrderBy(x => x.Naziv)
            .Select(x => new GradDto
            {
                IdGrad = x.IdGrad,
                Naziv = x.Naziv
            })
            .ToListAsync(ct);
    }
}
