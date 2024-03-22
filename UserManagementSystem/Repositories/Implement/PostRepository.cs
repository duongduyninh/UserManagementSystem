using AutoMapper;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem.Repositories.Implement
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using UserManagementSystem.Helpers;
    using UserManagementSystem.Models.Entities;

    public class PostRepository : IPostRopository
    {
        private readonly ManagementSystemContext _context;
        private readonly IMapper _mapper;
        public PostRepository(ManagementSystemContext context
                               , IMapper mapper
                               )
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> checkRole(PostModel postModel)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == postModel.UserId);
            if (user != null)
            {
                var getRoleId = _context.UserRoles.FirstOrDefault(u => u.UserId == user.Id);
                if (getRoleId != null)
                {
                    return (int)Enum.CheckRoleResult.Achieved;
                }
                else
                {
                    return (int)Enum.CheckRoleResult.Nonexistent;
                }
            } else
            {
                return (int)Enum.CheckRoleResult.IncorrectUserId;
            }
        }

        public async Task<string> PostAsync(PostModel postModel)
        {
            var checkResult = await checkRole(postModel);

            switch (checkResult)
            {
                case 0:
                    return "UserId sai ";
                case 1:
                    return "User chua co role";
                case 2:
                    return "khong du dang cap";
                case 3:
                    await AddPostAsync(postModel);
                    return "Dang thanh cong";
                default:
                    return "Tùy Duyên vậy";
            }
        }

        public async Task<string> AddPostAsync(PostModel postModel)
        {
            var getInfoUser = _context.Users.FirstOrDefault(u => u.Id == postModel.UserId);
            if (getInfoUser != null)
            {
                var post = _mapper.Map<Post>(postModel);
                post.NameAuthor = getInfoUser.Name;
                post.Status = "1";
                post.UserId = getInfoUser.Id;

                _context.Posts.Add(post);
                await _context.SaveChangesAsync();
                return post.ToString();
            }
            return "Tuy Duyen vay";
        }


        public Task<string> UpdatePost()
        {
            throw new NotImplementedException();
        }

        public async Task<List<InfPostModel>> ListPostAsync()
        {
            var posts = await _context.Posts.ToListAsync();

            var infPosts = _mapper.Map<List<InfPostModel>>(posts);

            return infPosts; 
        }

        
    }
}
