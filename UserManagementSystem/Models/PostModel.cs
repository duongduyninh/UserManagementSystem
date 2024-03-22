using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class PostModel
    {
        [Required]
        public string? title { get; set; }
        [Required]
        public Guid? UserId { get; set; }

    }
}
