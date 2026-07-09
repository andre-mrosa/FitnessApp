using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.CreateVersion7();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
