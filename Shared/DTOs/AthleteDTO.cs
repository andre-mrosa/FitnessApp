namespace Shared.DTOs
{
    public class AthleteDTO : UserBaseDTO
    {
        public List<CoachDTO> Coaches { get; set; } = [];
        public List<TrainingPlanDTO> TrainingPlanDTOs { get; set; } = [];
    }
}
