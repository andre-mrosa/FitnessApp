using System.ComponentModel.DataAnnotations;

namespace API.Entities.Users
{
    public class UserBaseEntity : BaseEntity
    {
        [MaxLength(100)]
        public required string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Photo { get; set; }
    }
}
