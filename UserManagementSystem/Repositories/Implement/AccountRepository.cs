using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using System.Data;
using UserManagementSystem.Data;
using UserManagementSystem.Helpers;
using UserManagementSystem.Models;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Repositories.Implement
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMapper _mapper;
        private readonly ManagementSystemContext _context;

        public AccountRepository(ManagementSystemContext context, IMapper mapper) {
            _mapper = mapper;
            _context = context;
        }

        public async Task<string> SignUpAsync(SignUpModel model)
        {
            var addUser = await _context.AddAsync(model);

            if (addUser.State == EntityState.Added)
            {
                await _context.SaveChangesAsync();
                return "ADD true";
            }
            else
            {
                return "ADD false";
            }
        }
        public async Task<InfLoginModel> SignInAsync(SignInModel signInModel)
        {

            var user = await _context.Users.FirstOrDefaultAsync(u=>u.Email == signInModel.Email);
            if (user == null || user.Password != signInModel.Password)
            {
                return null;
            }

            var UserRole = await _context.UserRoles.FirstOrDefaultAsync(u => u.UserId == user.Id);
            if (UserRole == null)
            {
                var getRoles = await _context.Roles.FirstOrDefaultAsync( u => u.NameRole == AppRole.Customer);
                var addUserRole = new UserRole { UserId = user.Id, RoleId = getRoles.Id };
                _context.UserRoles.AddAsync(addUserRole);
                await _context.SaveChangesAsync();
            }
            if(user != null)
            {
                var getRoleId = await _context.UserRoles.FirstOrDefaultAsync(r => r.UserId == user.Id);
                var getNameRole = await _context.Roles.FirstOrDefaultAsync(r => r.Id == getRoleId.RoleId);
      
                if(getRoleId != null)
                {
                    return new InfLoginModel
                    {
                        Name = user.Name,
                        NameRole = getNameRole.NameRole ,
                        UserId = user.Id
                    };
                }
            }
            return null;

        }

        public async Task<List<ListUserModel>> ListUserAsync()
        {
            var users = await _context.Users.ToListAsync();
            return _mapper.Map<List<ListUserModel>>(users);

        }

        
    }
}
