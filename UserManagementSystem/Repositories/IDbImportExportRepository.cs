using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Models;

namespace UserManagementSystem.Repositories
{
    public interface IDbImportExportRepository
    {
        public Task<IActionResult> ImPortPostFileCSV();
        public Task<string> ExPortPostFileCSV();

    }
}
