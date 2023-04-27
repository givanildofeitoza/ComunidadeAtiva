using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using ComunidadeAtiva.Infra.Data.EntidadesConfig;
using Microsoft.EntityFrameworkCore;


namespace ComunidadeAtiva.Infra.Data.DbContextFiles
{
    public class FileDbContext:DbContext
    {
        //para gerar nova migration sem erros, remover o construtor
       public FileDbContext(DbContextOptions options):
            base(options)
        {
            
        }
      
        public DbSet<Morador> morador { get; set; }
        public DbSet<Associacao> associacao { get; set; }
        public DbSet<AssociacaoCargo> associacaoCargo { get; set; }
        public DbSet<AssociacaoEvento> associacaoEvento { get; set; }
        public DbSet<AssociacaoPatrimonio> associacaoPatrimonio { get; set; }
        public DbSet<AssociacaoPrograma> associacaoPrograma { get; set; }
        public DbSet<Associado> associado { get; set; }
        public DbSet<BeneficioSocial> beneficioSocial { get; set; }
        public DbSet<CorpoDirigenteAssociacao> corpoDirigenteAssociacao { get; set; }
        public DbSet<Dependente> dependente { get; set; }
        public DbSet<MoradorBeneficioSocial> moradorBeneficioSocial { get; set; }
        public DbSet<MoradorNecessidadeEspecial> moradorNecessidadeEspecial { get; set; }
        public DbSet<MoradorPrograma> moradorPrograma { get; set; }
        public DbSet<NecessidadeEspecial> necessidadeEspecial { get; set; }
        public DbSet<Rua> rua { get; set; }

         /*para funcionar a migration
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              var ConnectionStrings = "server=localhost; port=3307; uid=root;pwd=p@ssw0rd;database=comunidade";
              optionsBuilder.UseMySql(ConnectionStrings,ServerVersion.AutoDetect(ConnectionStrings));

          }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //precisa do entityframeworkrelational para funcionar
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MoradorConfig());
            modelBuilder.ApplyConfiguration(new AssociacaoConfig());
            modelBuilder.ApplyConfiguration(new AssociadoConfig());
            modelBuilder.ApplyConfiguration(new AssociacaoCargoConfig());
            modelBuilder.ApplyConfiguration(new AssociacaoEventoConfig());
            modelBuilder.ApplyConfiguration(new AssociacaoPatrimonioConfig());
            modelBuilder.ApplyConfiguration(new AssociacaoProgramaConfig());
            modelBuilder.ApplyConfiguration(new BeneficioSocialConfig());
            modelBuilder.ApplyConfiguration(new CorpoDirigenteAssociacaoConfig());
            modelBuilder.ApplyConfiguration(new DependenteConfig());
            modelBuilder.ApplyConfiguration(new MoradorBeneficioSocialConfig());
            modelBuilder.ApplyConfiguration(new MoradorNecessidadeEspecialConfig());
            modelBuilder.ApplyConfiguration(new MoradorProgramaConfig());
            modelBuilder.ApplyConfiguration(new NecessidadeEspecialConfig());
            modelBuilder.ApplyConfiguration(new RuaConfig());
            //precisa do entityframeworkrelational para funcionar

            modelBuilder.Entity<Morador>().HasKey(p=>p.id);
            modelBuilder.Entity<Associacao>().HasKey(p => p.id);
            modelBuilder.Entity<Associado>().HasKey(p => p.id);
            modelBuilder.Entity<AssociacaoCargo>().HasKey(p => p.id);
            modelBuilder.Entity<AssociacaoEvento>().HasKey(p => p.id);
            modelBuilder.Entity<AssociacaoPatrimonio>().HasKey(p => p.id);
            modelBuilder.Entity<AssociacaoPrograma>().HasKey(p => p.id);
            modelBuilder.Entity<BeneficioSocial>().HasKey(p => p.id);
            modelBuilder.Entity<CorpoDirigenteAssociacao>().HasKey(p => p.id);
            modelBuilder.Entity<Dependente>().HasKey(p => p.id);
            modelBuilder.Entity<MoradorBeneficioSocial>().HasKey(p => p.id);
            modelBuilder.Entity<MoradorNecessidadeEspecial>().HasKey(p => p.id);
            modelBuilder.Entity<MoradorPrograma>().HasKey(p => p.id);
            modelBuilder.Entity<NecessidadeEspecial>().HasKey(p => p.id);
            modelBuilder.Entity<Rua>().HasKey(p => p.id);
            
           

        }

    }
}
