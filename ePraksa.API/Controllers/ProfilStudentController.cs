using MediatR;
using Microsoft.AspNetCore.Mvc;
using ePraksa.Application.Modules.ProfilStudent.DTOs;
using ePraksa.Application.Modules.ProfilStudent.Commands.Create;
using ePraksa.Application.Modules.ProfilStudent.Queries.GetById;

namespace ePraksa.API.Controllers;

[ApiController]
[Route("api/profil-student")]
public class ProfilStudentController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProfilStudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // POST: api/profil-student
    [HttpPost]
    public async Task<ActionResult<int>> Create([FromBody] CreateProfilStudentRequest body)
    {
        var idProfil = await _mediator.Send(new CreateProfilStudentCommand(body));
        return CreatedAtAction(nameof(GetById), new { id = idProfil }, idProfil);
    }

    // GET: api/profil-student/{id}
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetProfilStudentByIdQuery(id));
        if (result == null)
            return NotFound();

        return Ok(result);
    }
}
