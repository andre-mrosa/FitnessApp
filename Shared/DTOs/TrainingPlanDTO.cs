namespace Shared.DTOs
{
    public class TrainingPlanDTO
    {
        public required string Title { get; set; }
        public List<ExerciseDTO> ExerciseDTOs { get; set; } = [];
        public string Description { get; set; } = string.Empty;
        public string PersonalTrainerNotes { get; set; } = string.Empty;
        public string AthleteNotes { get; set; } = string.Empty;
    }
}
