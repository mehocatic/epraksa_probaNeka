using MediatR;
using Microsoft.AspNetCore.Mvc;
using ePraksa.Application.Modules.Tehnologija.Queries.GetTehnologije;

namespace ePraksa.API.Controllers;

[ApiController]
[Route("api/tehnologija")]
public class TehnologijaController(ISender sender) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken ct)
        => Ok(await sender.Send(new GetTehnologijeQuery(), ct));
}
