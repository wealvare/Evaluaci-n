using Microsoft.EntityFrameworkCore;
using WebAPI_2026._11._06_Wilber_Alvarez.Data;
using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Mapper;
using WebAPI_2026._11._06_Wilber_Alvarez.Repository;
using WebAPI_2026._11._06_Wilber_Alvarez.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<UsuarioMapper>();
builder.Services.AddScoped<UsuarioService>();

//--------BD----------
//--------------------
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);


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
