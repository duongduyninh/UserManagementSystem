using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UserManagementSystem.Data;
using UserManagementSystem.Helpers;
using UserManagementSystem.Models.Entities;
using UserManagementSystem.Repositories;
using UserManagementSystem.Repositories.Implement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ApplicationAutoMapper).Assembly);
/*
builder.Services.AddIdentity<AppUser , IdentityRole>()
                .AddEntityFrameworkStores< ManagementSystemContext >()
                .AddDefaultTokenProviders();
*/
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IPostRopository, PostRepository>();
builder.Services.AddScoped<IDbImportExportRepository , DbImportExportRepository>();


builder.Services.AddCors(options =>
        options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())
);

builder.Services.AddDbContext<ManagementSystemContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("ManagementSystem");
    options.UseSqlServer(connectionString);
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
