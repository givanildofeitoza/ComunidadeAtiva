using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ComunidadeAtiva.Aplicacao.Mapeamento;
using AutoMapper;
using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.CasosDeUso;
using ComunidadeAtiva.Aplicacao.Repositorio;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using Microsoft.AspNetCore.Identity;



namespace ComunidadeAtiva.Ioc
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ConfigDependency(this IServiceCollection Services)
        {            
               var ConnectionStrings = "server=localhost; port=3307; uid=root;pwd=p@ssw0rd;database=comunidade";
               Services.AddDbContext<IdentityFileDbContext>(options => options.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)));
               Services.AddDbContext<FileDbContext>(opt => opt.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)));
               Services.AddScoped<DbContext, FileDbContext>();
               Services.AddScoped<ICapturarNotificacao, CapturarNotificacao>();
               Services.AddScoped<ImoradorRepositorio, MoradorRepositorio>();
               Services.AddScoped<IbeneficioSocialRepositorio, BeneficioSocialRepositorio>();
               Services.AddScoped<ImoradorBeneficioSocialRepositorio, MoradorBeneficioSocialRepositorio>();
               Services.AddScoped<InecessidadeEspecialRepositorio, NecessidadeEspecialRepositorio>();
               Services.AddScoped<IcorpoDirigenteAssociacaoRepositorio, CorpoDirigenteAssociacaoRepositorio>();
               Services.AddScoped<ImoradorNecessidadeEspecialRepositorio, MoradorNecessidadeEspecialRepositorio>();
               Services.AddScoped<IServicoRua, ServicoRua>();
               Services.AddScoped<IServicoMorador, ServicoMorador>();
               Services.AddScoped<IServicoBeneficoSocialMorador, ServicoBeneficoSocialMorador>();
               Services.AddScoped<IServicoNecessidadeMorador, ServicoNecessidadeMorador>();
               Services.AddScoped<IServicoBeneficioSocial, ServicoBeneficioSocial>();
               Services.AddScoped<IServicoNecessidadeEspecial, ServicoNecessidadeEspecial>();
               Services.AddScoped<IServicoCorpoDirigenteAssociacao, ServicoCorpoDirigenteAssociacao>();
               Services.AddScoped<IServicoAssociacao, ServicoAssociacao>();
               Services.AddScoped<IruaRepositorio, RuaRepositorio>();
               Services.AddScoped<IassociacaoRepositorio, AssociacaoRepositorio>();              
               Services.AddScoped<IServiceSegurancaIdentity, ServiceSegurancaIdentity>();
               Services.AddAutoMapper(typeof(MapeamentoClasseDTO));        
               Services.AddIdentityCore<IdentityUser>()
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<IdentityFileDbContext>();
           
            /*services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddScoped<DbContext, appDbContext>();
            */

            //  services.AddScoped<IInputRelationsService, InputRelationsRepository>();
            // services.AddScoped<ICustomerService, CustomerRepository>();

            /*
            services.AddApiVersioning(options =>
            {

                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });

            
            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
            */

            return Services;

        }
    }
}
