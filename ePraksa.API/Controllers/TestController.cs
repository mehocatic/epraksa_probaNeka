using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ePraksa.Infrastructure.Database;

namespace ePraksa.API.Controllers;

[ApiController]
[Route("api/test")]
public class TestController(DatabaseContext db) : ControllerBase
{
    [HttpGet("gradovi")]
    public async Task<IActionResult> Gradovi() => Ok(await db.Gradovi.AsNoTracking().ToListAsync());

    [HttpGet("tehnologije")]
    public async Task<IActionResult> Tehnologije() => Ok(await db.Tehnologije.AsNoTracking().ToListAsync());
}
