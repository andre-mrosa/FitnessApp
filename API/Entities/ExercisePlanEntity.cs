using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("ExercisePlans")]
    public class ExercisePlanEntity : EntityBase
    {
        [Required]
        public Guid ExerciseId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        public required ExerciseEntity Exercise { get; set; }

        public Guid? TrainingPlanId { get; set; }

        [ForeignKey(nameof(TrainingPlanId))]
        public TrainingPlanEntity? TrainingPlan { get; set; }

        public int Repetitions { get; set; }

        [MaxLength(2000)]
        public string PersonalTrainerNotes { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string AthleteNotes { get; set; } = string.Empty;
    }
}