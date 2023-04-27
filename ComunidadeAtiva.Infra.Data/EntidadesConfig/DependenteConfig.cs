using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class DependenteConfig : IEntityTypeConfiguration<Dependente>
    {
        public void Configure(EntityTypeBuilder<Dependente> builder)
        {            
            builder.Property(p => p.IdMoradorMaster).HasMaxLength(5).IsRequired();
            builder.Property(p => p.IdMoradorDependente).HasMaxLength(5).IsRequired();
            builder.Property(p => p.Ativo).HasMaxLength(1).HasDefaultValue("S");
        
        }
    }
}
