using UserManagementSystem.Models;

namespace UserManagementSystem.Repositories
{
    public interface IAccountRepository
    {
        public Task<InfLoginModel> SignInAsync(SignInModel model);
        public Task<string> SignUpAsync(SignUpModel model);

        public Task<List<ListUserModel>> ListUserAsync();
    }
}
        