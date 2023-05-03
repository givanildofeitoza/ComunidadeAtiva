using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ComunidadeAtiva.Infra.Data.Repositorio;
using ComunidadeAtiva.Dominio.Entity;

namespace ComunidadeAtiva.FormsUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var _FrmMain = serviceProvider.GetRequiredService<FrmMain>();
                Application.Run(_FrmMain);
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
           

        }
        private static void ConfigureServices(ServiceCollection services)
        {
            var ConnectionStrings = "server=localhost; port=3307; uid=root;pwd=p@ssw0rd;database=comunidade";
            
            services.AddLogging(configure => configure.AddConsole())
                .AddDbContext<FileDbContext>(opt => opt.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)))
                .AddScoped<DbContext, FileDbContext>()
                .AddSingleton<Imorador, RepositorioMorador>()
                .AddSingleton<IbeneficioSocial, RepositorioBeneficioSocial>()
                .AddSingleton <ImoradorBeneficioSocial, RepositorioMoradorBeneficioSocial>()
                .AddSingleton<InecessidadeEspecial, RepositorioNecessidadeEspecial>()
                .AddSingleton<ImoradorNecessidadeEspecial, RepositorioMoradorNecessidadeEspecial>()
                .AddSingleton<Irua, RepositorioRua>()
                .AddScoped<FrmMain>();
           
        }

    }
}