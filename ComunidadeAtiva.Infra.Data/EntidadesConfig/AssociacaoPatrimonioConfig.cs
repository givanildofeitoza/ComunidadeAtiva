using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class AssociacaoPatrimonioConfig : IEntityTypeConfiguration<AssociacaoPatrimonio>
    {
        public void Configure(EntityTypeBuilder<AssociacaoPatrimonio> builder)
        {            
            builder.Property(p => p.DescricaoPatrimonio).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Tipo).HasMaxLength(2).IsRequired();
            builder.Property(p => p.ValorEstimado).HasPrecision(8,2).HasDefaultValue(0.00);
            builder.Property(p => p.DataAquisicao).HasDefaultValue("1900-01-01 00:00:00");
        }
    }
}
