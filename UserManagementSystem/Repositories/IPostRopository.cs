using UserManagementSystem.Models;
namespace UserManagementSystem.Repositories
{
    public interface IPostRopository
    {
        public Task<int> checkRole(PostModel mode);
        public Task<string> PostAsync(PostModel model);
        public Task<string> UpdatePost();
        public Task<string> AddPostAsync(PostModel model);
        public Task<List<InfPostModel>> ListPostAsync();
    }

  
}
