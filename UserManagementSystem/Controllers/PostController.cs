using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Repositories;

namespace UserManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly ManagementSystemContext _context;
        private readonly IPostRopository _postRepository;

        public PostController(ManagementSystemContext context
                            ,IPostRopository postRepository)
        { 
            _context = context;
            _postRepository = postRepository;
        }
        [HttpPost("Post")]
        public async Task<IActionResult> Post(PostModel postModel)
        {
            try
            {
                return Ok(await _postRepository.PostAsync(postModel));
            }catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ListPost")]
        public async Task<IActionResult> getListPost ()
        {
            try
            {
                return Ok(await _postRepository.ListPostAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
