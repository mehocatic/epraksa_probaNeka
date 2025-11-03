using MediatR;
using ePraksa.Application.Modules.Grad.Dtos;

namespace ePraksa.Application.Modules.Grad.Queries.GetGradovi;

public record GetGradoviQuery() : IRequest<List<GradDto>>;
