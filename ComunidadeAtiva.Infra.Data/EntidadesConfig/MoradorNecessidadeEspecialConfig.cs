using ComunidadeAtiva.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class MoradorNecessidadeEspecialConfig : IEntityTypeConfiguration<MoradorNecessidadeEspecial>
    {
        public void Configure(EntityTypeBuilder<MoradorNecessidadeEspecial> builder)
        {            
            builder.Property(p => p.MoradorId).HasMaxLength(6).IsRequired();
            builder.Property(p => p.NecessidadeId).HasMaxLength(6).IsRequired();
            builder.Property(p => p.Ativo).HasMaxLength(1).HasDefaultValue("S");
        }
    }
}
