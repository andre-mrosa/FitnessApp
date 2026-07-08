using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TrainingPlanEntity> PlanosTreino { get; set; }
        public DbSet<ExerciseEntity> Exercises { get; set; }
    }
}
