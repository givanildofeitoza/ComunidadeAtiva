using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class CorpoDirigenteAssociacaoConfig : IEntityTypeConfiguration<CorpoDirigenteAssociacao>
    {
        public void Configure(EntityTypeBuilder<CorpoDirigenteAssociacao> builder)
        {            
            builder.Property(p => p.Nome).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Ativo).HasMaxLength(1).HasDefaultValue("S");
            builder.Property(p => p.Apelido).HasMaxLength(50);
            builder.Property(p => p.IdCargo).HasMaxLength(2).IsRequired();
            builder.Property(p => p.IdAssociacao).HasMaxLength(4).IsRequired();
            builder.Property(p => p.Celular).HasMaxLength(20);
        }
    }
}
