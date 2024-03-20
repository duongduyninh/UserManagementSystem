using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models.Entities
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? title { get; set; }
        [Required]
        public string? NameAuthor { get; set; }
        [Required]
        public int IdUser { get; set; }

    }
}
