using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadeAtiva.Infra.Data.DbContextFiles
{
    public class IdentityFileDbContext : IdentityDbContext
    {
        public IdentityFileDbContext()
        {
        }

        public IdentityFileDbContext(DbContextOptions<IdentityFileDbContext> options) 
            : base(options)
        {

        }

        //para rodar a migration
        //EntityFrameworkCore\add-migration identityDb -Context IdentityFileDbContext
        // EntityFrameworkCore\update-database -Context IdentityFileDbContext

        //para criar os indices, mude os tamanhos nas tabelas onde as chaves são 256 para 128


        // para funcionar a migration e comente o construtor
        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               var ConnectionStrings = "server=localhost; port=3307; uid=root;pwd=p@ssw0rd;database=comunidade";
               optionsBuilder.UseMySql(ConnectionStrings,ServerVersion.AutoDetect(ConnectionStrings));     
          

          }*/
    }
}
