using Microsoft.AspNetCore.Mvc;

namespace GraphicHabits.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HabitController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHabits()
    {
        return Ok("Hola desde HabitController");
    }
}