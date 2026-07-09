namespace Shared.DTOs
{
    public class ExerciseDTO
    {
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? Image { get; set; }
    }
}
