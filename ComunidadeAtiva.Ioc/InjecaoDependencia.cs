using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace ComunidadeAtiva.Ioc
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection ConfigDependency(this IServiceCollection services)
        {

            var ConnectionStrings = "server=localhost; port=3307; uid=root;pwd=p@ssw0rd;database=comunidade";
            services.AddDbContext<FileDbContext>(options => options.UseMySql(ConnectionStrings, ServerVersion.AutoDetect(ConnectionStrings)));
            
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

            return services;

        }
    }
}
