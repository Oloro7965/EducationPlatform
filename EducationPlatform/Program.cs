
using EducationPlatform.application.Commands.CreateUserCommand;
using EducationPlatform.application.InputModel;
using EducationPlatform.application.Services.Implementations;
using EducationPlatform.application.Services.Interfaces;
using EducationPlatform.Infraestructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EducationPlatformDbContext>(options =>
   options.UseInMemoryDatabase("Database"));
//builder.Services.AddScoped<IUserService,UserService>();
//builder.Services.AddScoped<ISignatureService,SignatureService>();
//builder.Services.AddScoped<IModuleService,ModuleService>();
//builder.Services.AddScoped<ICourseService,CourseService>();
//builder.Services.AddScoped<IClassService,ClassService>();
builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssemblyContaining(typeof(CreateUserCommand)));
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
