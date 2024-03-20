using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Models.Entities;
using UserManagementSystem.Repositories;
using UserManagementSystem.Repositories.Implement;

namespace UserManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ManagementSystemContext _context;
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository
                                , ManagementSystemContext context
                                , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel SignUpModel)
        {
            var newUser = _mapper.Map<User>(SignUpModel);
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return Ok(newUser);
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel SignInModel)
        {
            var user = await _accountRepository.SignInAsync(SignInModel);
            if (user == null)
            {
                return BadRequest(); 
            }
            return Ok(user);
        }
        [HttpGet("lisetUser")]
        public async Task<IActionResult> ListUser()
        {
            try
            {
                return Ok(await _accountRepository.ListUserAsync());
            }catch
            {
                return BadRequest();
            }
        }
    }
}
