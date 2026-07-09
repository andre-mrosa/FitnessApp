namespace Shared.DTOs
{
    public class AthleteDTO : PersonBaseDTO
    {
        public List<CoachDTO> Coaches { get; set; } = [];
        public List<TrainingPlanDTO> TrainingPlanDTOs { get; set; } = [];
    }
}
