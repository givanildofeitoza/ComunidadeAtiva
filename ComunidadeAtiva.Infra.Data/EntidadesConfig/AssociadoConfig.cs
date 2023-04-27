using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class AssociadoConfig : IEntityTypeConfiguration<Associado>
    {
        public void Configure(EntityTypeBuilder<Associado> builder)
        {            
            builder.Property(p => p.Ativo).HasMaxLength(1).IsRequired();
            builder.Property(p => p.IdMorador).HasMaxLength(6).IsRequired();
            builder.Property(p => p.NumeroItentificacao).HasMaxLength(30).IsRequired();
            
        }
    }
}
