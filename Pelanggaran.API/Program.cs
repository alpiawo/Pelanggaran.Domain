using Microsoft.EntityFrameworkCore;
using Pelanggaran.Application;
using Pelanggaran.Domain;
using Pelanggaran.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

var serverVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, serverVersion));

//Jurusan
builder.Services.AddScoped<IJurusanRepository, JurusanRepository>();
builder.Services.AddScoped<IJurusanService, JurusanService>();

//Kelas
builder.Services.AddScoped<IKelasRepository, KelasRepository>();
builder.Services.AddScoped<IKelasService, KelasService>();

//Peraturan
builder.Services.AddScoped<IPeraturanRepository, PeraturanRepository>();
builder.Services.AddScoped<IPeraturanService, PelanggaranService>();

//Guru
builder.Services.AddScoped<IGuruRepository, GuruRepository>();
builder.Services.AddScoped<IGuruService, GuruService>();

//Siswa
builder.Services.AddScoped<ISiswaRepository, SiswaRepository>();
builder.Services.AddScoped<ISiswaService, SiswaService>();

//User
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

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

app.UseCors(options => options
    .WithOrigins("http://localhost:3000")
    .AllowAnyHeader()
    .AllowAnyMethod()
    );

app.Run();
