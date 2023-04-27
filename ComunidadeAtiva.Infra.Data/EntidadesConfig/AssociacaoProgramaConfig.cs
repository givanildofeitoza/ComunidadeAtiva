using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class AssociacaoProgramaConfig : IEntityTypeConfiguration<AssociacaoPrograma>
    {
        public void Configure(EntityTypeBuilder<AssociacaoPrograma> builder)
        {            
            builder.Property(p => p.DescricaoPrograma).HasMaxLength(200).IsRequired();
            builder.Property(p => p.NomePrograma).HasMaxLength(50);
            builder.Property(p => p.Ativo).HasMaxLength(1).IsRequired().HasDefaultValue("S");
            
        }
    }
}
