using MediatR;
using Microsoft.AspNetCore.Mvc;
using ePraksa.Application.Modules.Grad.Queries.GetGradovi;

namespace ePraksa.API.Controllers;

[ApiController]
[Route("api/grad")]
public class GradController(ISender sender) : ControllerBase
{
    /// <summary>Vraća listu svih gradova (lookup za profile studenta/kompanije).</summary>
    [HttpGet]
    public async Task<IActionResult> GetGradovi(CancellationToken ct)
        => Ok(await sender.Send(new GetGradoviQuery(), ct));
}
