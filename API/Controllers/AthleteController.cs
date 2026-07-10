using API.Data;
using API.Entities.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("api/athletes")]
    public class AthleteController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<List<AthleteEntity>>> GetAll()
        {
            var athletes = await _context.Athletes.ToListAsync();
            return Ok(athletes);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AthleteDTO athleteDto)
        {
            var athlete = new AthleteEntity
            {
                Name = athleteDto.Name,
                BirthDate = athleteDto.BirthDate
            };

            _context.Add(athlete);
            await _context.SaveChangesAsync();
            return Ok(athlete);
        }
    }
}
