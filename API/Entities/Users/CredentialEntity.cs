using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities.Users
{
    [Table("Credentials")]
    public class CredentialEntity : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public required string Username { get; set; }

        [Required]
        [MaxLength(256)]
        public required string PasswordHash { get; set; }

        [Required]
        [MaxLength(256)]
        public required string Email { get; set; }

        [Required]
        public required bool IsCoach { get; set; }
    }
}
