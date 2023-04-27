using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class AssociacaoEventoConfig : IEntityTypeConfiguration<AssociacaoEvento>
    {
        public void Configure(EntityTypeBuilder<AssociacaoEvento> builder)
        {            
            builder.Property(p => p.DelegadoAssociacao).HasMaxLength(3).IsRequired();
            builder.Property(p => p.NumeroParticipanteEstimado).HasMaxLength(4);
            builder.Property(p => p.DescricaoEvento).HasMaxLength(50).IsRequired();
            builder.Property(p => p.MesEvento).HasMaxLength(2).IsRequired();
            builder.Property(p => p.CustoEstimado).HasPrecision(6,2).IsRequired();
            builder.Property(p => p.MoradorSolicitante).HasMaxLength(50);
            builder.Property(p => p.AnoEvento).HasMaxLength(4);
            

        }
    }
}
