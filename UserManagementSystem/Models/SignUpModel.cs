using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class SignUpModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public string Name { get; set; } = null!;
    }
}
