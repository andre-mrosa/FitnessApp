using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class PersonBaseEntity : BaseEntity
    {
        [MaxLength(100)]
        public required string Name { get; set; }

        public DateOnly BirthDate { get; set; }

        public string? Photo { get; set; }
    }
}
