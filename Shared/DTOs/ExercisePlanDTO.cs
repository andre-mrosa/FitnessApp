namespace Shared.DTOs
{
    public class ExercisePlanDTO
    {
        public required ExerciseDTO ExerciseDTO { get; set; }
        public int Repetitions { get; set; }
        public string PersonalTrainerNotes { get; set; } = string.Empty;
        public string AthleteNotes { get; set; } = string.Empty;
    }
}
