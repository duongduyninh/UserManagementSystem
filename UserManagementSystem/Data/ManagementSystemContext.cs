using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using UserManagementSystem.Helpers;
using UserManagementSystem.Models.Entities;
using UserManagementSystem.Models.EntityConfigurations;

namespace UserManagementSystem.Data
{
    public class ManagementSystemContext : DbContext
    {
        public ManagementSystemContext(DbContextOptions<ManagementSystemContext> options) : base(options) {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = Guid.NewGuid(), NameRole = AppRole.Admin},
                new Role { Id = Guid.NewGuid(), NameRole = AppRole.Manager },
                new Role { Id = Guid.NewGuid(), NameRole = AppRole.Staff },
                new Role { Id = Guid.NewGuid(), NameRole = AppRole.Customer }
            );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
