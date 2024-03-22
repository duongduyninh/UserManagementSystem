using AutoMapper;
using CsvHelper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Repositories.Implement
{
    public class DbImportExportRepository : IDbImportExportRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ManagementSystemContext _context;
        private readonly IMapper _mapper;

        public DbImportExportRepository(ManagementSystemContext context 
                                        ,IMapper mapper
                                        , IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;
            _mapper = mapper;
        }
        public async Task<string> ExPortPostFileCSV()
        {
            string currentDate = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string fileName = $"ExPortPost_{currentDate}.csv";

            /* cai nay la lay duong dan cua project */
            var currentDirectory = _webHostEnvironment.ContentRootPath;

            string repositoryPath = Path.Combine(currentDirectory, "Repositories");

            string folderPath = Path.Combine(repositoryPath, "File");

            var filePath = Path.Combine(folderPath, fileName);

            var posts = await _context.Posts.ToListAsync();

            var exPortPost = _mapper.Map<List<Post>>(posts);

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(exPortPost);
                return fileName;
            }
        }


        public Task<IActionResult> ImPortPostFileCSV()
        {
            throw new NotImplementedException();
        }

      
    }
}
