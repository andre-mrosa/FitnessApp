namespace Shared.DTOs
{
    public class CoachDTO : UserBaseDTO
    {
        public List<AthleteDTO> AtheleteDTOs { get; set; } = [];
    }
}
