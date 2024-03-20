using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models.Entities
{
    [Table("Roles")]
    public class Role
    {
        public Guid Id { get; set; }
        [Required]
        public string? NameRole { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

    }
}
