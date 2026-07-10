using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("api/exercises")]
    public class ExercisesController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<List<ExerciseEntity>>> GetAll()
        {
            var exercises = await _context.Exercises.ToListAsync();
            return Ok(exercises);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExerciseDTO dto)
        {
            var entity = new ExerciseEntity
            {
                Title = dto.Title,
                Description = dto.Description
            };

            _context.Add(entity);
            await _context.SaveChangesAsync();
            return Ok(entity);
        }
    }
}
