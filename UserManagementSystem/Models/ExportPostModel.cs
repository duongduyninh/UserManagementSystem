using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Models
{
    public class ExportPostModel
    {
        public Guid Id { get; set; }
        [Required]
        public string? title { get; set; }
        [Required]
        public string? NameAuthor { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string? Status { get; set; }
    }
}
