using MediatR;
using ePraksa.Application.Modules.ProfilStudent.DTOs;

namespace ePraksa.Application.Modules.ProfilStudent.Queries.GetById;

public record GetProfilStudentByIdQuery(int IdProfil) : IRequest<ProfilStudentDto?>;
