using ComunidadeAtiva.Infra.Data.DbContextFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Ioc
{
    public static class Start
    {
        public static void StartUp(IHostBuilder builder)
        {
            builder
            .ConfigureServices((hostContext, services) =>
            {

                services.ConfigDependency();
               services.AddDbContext<FileDbContext>();
                //services.AddSingleton<Form1>();
                //services.AddLogging(configure => configure.AddConsole());
                //services.AddScoped<IBusinessLayer, BusinessLayer>();
                //services.AddScoped<IDataAccessLayer, CDataAccessLayer>();

            });
        }
    }
}
