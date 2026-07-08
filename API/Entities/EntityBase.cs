using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
