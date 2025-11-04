using MediatR;
using ePraksa.Application.Modules.ProfilStudent.DTOs;

namespace ePraksa.Application.Modules.ProfilStudent.Commands.Update;

public record UpdateProfilStudentCommand(int IdProfil, UpdateProfilStudentRequest Body) : IRequest;
