using ComunidadeAtiva.Aplicacao.Mapeamento;
using Microsoft.AspNetCore.Identity;
using ComunidadeAtiva.Ioc;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDefaultIdentity<IdentityUser>();




var ConnectionStrings = builder.Configuration.GetConnectionString("MySql");
builder.Services.AddDbContext<IdentityFileDbContext>(options => options.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)));
builder.Services.AddDbContext<FileDbContext>(opt => opt.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)));

builder.Services.ConfigDependency();
builder.Services.ConfigIdentity(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapeamentoClasseDTO));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseAuthentication();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
