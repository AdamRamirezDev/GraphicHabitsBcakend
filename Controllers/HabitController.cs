using GraphicHabitsBackend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GraphicHabits.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HabitController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHabits()
    {
        var habits = new List<Habit>
        {
            new Habit
            {
                ID = 1,
                Name = "Leer",
                Color = "Blue"
            },
            new Habit
            {
                ID = 2,
                Name = "Correr",
                Color = "Red"
            }
        };
        return Ok(habits);
    }
}