using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Exercises")]
    public class ExerciseEntity : EntityBase
    {

        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public ExerciseImageEntity? Image { get; set; }
    }
}
