using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Models.EntityConfigurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            // Tạo khóa ngoại giữa Post và User
            builder.HasOne(p => p.User) // Một bài viết chỉ thuộc về một người dùng (một User)
                   .WithMany(u => u.Posts) // Một người dùng có thể có nhiều bài viết
                   .HasForeignKey(p => p.UserId); // Khóa ngoại của Post là UserId
        }
    }
}