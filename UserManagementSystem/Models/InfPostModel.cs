using System.ComponentModel.DataAnnotations;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Models
{
    public class InfPostModel
    {
        [Required]
        public string? title { get; set; }
        [Required]
        public string? NameAuthor { get; set; }

    }
}
