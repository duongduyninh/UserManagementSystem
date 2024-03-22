using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Data;
using UserManagementSystem.Repositories;
using UserManagementSystem.Repositories.Implement;

namespace UserManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportExportController : ControllerBase
    {
        private readonly ManagementSystemContext _context;
        private readonly IDbImportExportRepository _dbImportExportRepository;

        public ImportExportController(ManagementSystemContext context
                                            , IDbImportExportRepository dbImportExportRepository)
        {
            _context = context;
            _dbImportExportRepository = dbImportExportRepository;
        }

        [HttpGet("ExPortPost")]
        public async Task<IActionResult> ExPortPost()
        {
            try
            {
                return Ok( await _dbImportExportRepository.ExPortPostFileCSV());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
    }
}
