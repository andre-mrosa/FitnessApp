using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("TrainingPlans")]
    public class TrainingPlanEntity : EntityBase
    {
        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(2048)]
        public string PersonalTrainerNotes { get; set; } = string.Empty;

        [MaxLength(2048)]
        public string AthleteNotes { get; set; } = string.Empty;

        public ICollection<ExercisePlanEntity> ExercisePlans { get; set; } = [];
    }
}
