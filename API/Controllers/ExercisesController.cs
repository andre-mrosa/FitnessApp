using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExercisesController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpPost]
        public async Task<IActionResult> Create(ExerciseEntity entity)
        {
            _context.Exercises.Add(entity);
            await _context.SaveChangesAsync();
            return Ok(entity);
        }
    }
}
