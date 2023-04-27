using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class NecessidadeEspecialConfig : IEntityTypeConfiguration<NecessidadeEspecial>
    {
        public void Configure(EntityTypeBuilder<NecessidadeEspecial> builder)
        {            
            builder.Property(p => p.DescricaoNecessidadeEspecial).HasMaxLength(50).IsRequired();
            builder.Property(p => p.NecessitaRemedioControlado).HasMaxLength(1).HasDefaultValue("N");
            builder.Property(p => p.Permanete).HasMaxLength(1).HasDefaultValue("N");

        }
    }
}
