using MediatR;
using ePraksa.Application.Modules.ProfilStudent.DTOs;

namespace ePraksa.Application.Modules.ProfilStudent.Commands.Create;

public record CreateProfilStudentCommand(CreateProfilStudentRequest Body) : IRequest<int>;
