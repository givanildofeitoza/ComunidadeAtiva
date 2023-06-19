using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ComunidadeAtiva.Dominio.Validacao;
using ComunidadeAtiva.Aplicacao.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using ComunidadeAtiva.Aplicacao.Mapeamento;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.CasosDeUso;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Windows.Forms;

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
        private static void ConfigureServices(IServiceCollection services)
        {
            var ConnectionStrings = "server=localhost; port=3307; uid=root;pwd=p@ssw0rd;database=comunidade";

            services.AddLogging(configure => configure.AddConsole())
                .AddDbContext<IdentityFileDbContext>(options => options.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)))
                .AddDbContext<FileDbContext>(opt => opt.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)))
                .AddSingleton<DbContext, FileDbContext>()
                .AddAutoMapper(typeof(MapeamentoClasseDTO))
                .AddSingleton<ICapturarNotificacao, CapturarNotificacao>()
                .AddSingleton<ImoradorRepositorio, MoradorRepositorio>()
                .AddSingleton<IbeneficioSocialRepositorio, BeneficioSocialRepositorio>()
                .AddSingleton<ImoradorBeneficioSocialRepositorio, MoradorBeneficioSocialRepositorio>()
                .AddSingleton<InecessidadeEspecialRepositorio, NecessidadeEspecialRepositorio>()
                .AddSingleton<IcorpoDirigenteAssociacaoRepositorio, CorpoDirigenteAssociacaoRepositorio>()
                .AddSingleton<ImoradorNecessidadeEspecialRepositorio, MoradorNecessidadeEspecialRepositorio>()
                .AddSingleton<IServicoRua, ServicoRua>()
                .AddSingleton<IServicoMorador, ServicoMorador>()
                .AddSingleton<IServicoBeneficoSocialMorador, ServicoBeneficoSocialMorador>()
                .AddSingleton<IServicoNecessidadeMorador, ServicoNecessidadeMorador>()
                .AddSingleton<IServicoBeneficioSocial, ServicoBeneficioSocial>()
                .AddSingleton<IServicoNecessidadeEspecial, ServicoNecessidadeEspecial>()
                .AddSingleton<ICorpoDirigenteAssociacao,ServicoCorpoDirigenteAssociacao>()
                .AddSingleton<IruaRepositorio, RuaRepositorio>()
                .AddSingleton<IServiceSegurancaIdentity, ServiceSegurancaIdentity>()


                //.AddIdentityCore<IdentityUser>()


                //Para aparecer o AddAutomaper é preciso ao pacote nuguet AutoMappe.Extensions.Microsoft.DependencyInjection.
                .AddScoped<FrmMain>()
                .AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<IdentityFileDbContext>();
                
                
                

        }

    }
}