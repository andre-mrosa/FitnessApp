namespace Shared.DTOs
{
    public class CoachDTO : PersonBaseDTO
    {
        public List<AthleteDTO> AtheleteDTOs { get; set; } = [];
    }
}
