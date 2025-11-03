using MediatR;
using ePraksa.Application.Modules.Tehnologija.DTOs;

namespace ePraksa.Application.Modules.Tehnologija.Queries.GetTehnologije;

public record GetTehnologijeQuery() : IRequest<List<TehnologijaDto>>;
