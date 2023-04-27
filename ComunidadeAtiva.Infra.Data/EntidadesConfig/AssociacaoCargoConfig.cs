using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class AssociacaoCargoConfig : IEntityTypeConfiguration<AssociacaoCargo>
    {
        public void Configure(EntityTypeBuilder<AssociacaoCargo> builder)
        {            
            builder.Property(p => p.NivelAcesso).HasMaxLength(1).IsRequired();
            builder.Property(p => p.DescricaoCargo).HasMaxLength(50).IsRequired();
            
            
        }
    }
}
