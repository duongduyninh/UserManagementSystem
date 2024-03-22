using AutoMapper;
using UserManagementSystem.Models;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Helpers
{
    public class ApplicationAutoMapper : Profile
    {
        public ApplicationAutoMapper() {
             CreateMap<User, SignUpModel>().ReverseMap();
            CreateMap<User, ListUserModel>().ReverseMap();
            CreateMap<Post , PostModel>().ReverseMap();
            CreateMap<Post , InfPostModel>().ReverseMap();
            CreateMap<Post , ExportPostModel>().ReverseMap();
        }
    }
}
