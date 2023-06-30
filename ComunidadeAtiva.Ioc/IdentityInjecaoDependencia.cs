using ComunidadeAtiva.Aplicacao.ClasseConfig;
using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ComunidadeAtiva.Ioc
{
    public static class IdentityInjecaoDependencia
    {
        public static IServiceCollection ConfigIdentity(this IServiceCollection Services, IConfiguration configuration)
        {

           Services.AddIdentityCore<IdentityUser>()
              .AddRoles<IdentityRole>()
              .AddEntityFrameworkStores<IdentityFileDbContext>()
              .AddDefaultTokenProviders(); 

            //JWT
            var appSettingsSection = configuration.GetSection("AppSettings");
            Services.Configure<AppSetingsJWT>(appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSetingsJWT>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);


            Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = appSettings.ValidoEm,
                    ValidIssuer = appSettings.Emissor
                };

            });
            //JWT

            return Services;
        }
    }
}
