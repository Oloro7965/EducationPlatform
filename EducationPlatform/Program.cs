
using EducationPlatform.application.Services.Implementations;
using EducationPlatform.application.Services.Interfaces;
using EducationPlatform.Infraestructure.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<EducationPlatformDbContext>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<ISignatureService,SignatureService>();
builder.Services.AddScoped<IModuleService,ModuleService>();
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
