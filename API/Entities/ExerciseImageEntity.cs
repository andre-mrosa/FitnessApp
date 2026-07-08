using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("ExerciseImages")]
    public class ExerciseImageEntity
    {
        [Required]
        public byte[] Data { get; set; } = [];

        [Required]
        public string MimeType { get; set; } = "image/jpeg"; // Ex: image/jpeg, image/png

        // Foreign Key de volta para o exercício
        public Guid ExerciseId { get; set; }
        public required ExerciseEntity Exercise { get; set; }
    }
}
