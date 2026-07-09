using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TrainingPlanEntity> TrainingPlans { get; set; }
        public DbSet<ExerciseEntity> Exercises { get; set; }
        public DbSet<AthleteEntity> Athletes { get; set; }
    }
}
