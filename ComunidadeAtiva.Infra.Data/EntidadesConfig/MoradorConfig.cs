using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class MoradorConfig : IEntityTypeConfiguration<Morador>
    {
        public void Configure(EntityTypeBuilder<Morador> builder)
        {            
            builder.Property(p => p.Nome).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Cpf).HasMaxLength(11);
            builder.Property(p => p.Rg).HasMaxLength(10);
            builder.Property(p => p.EstadoCivil).HasMaxLength(20);
            builder.Property(p => p.Nascimento).HasDefaultValue("1900-01-01");
            builder.Property(p => p.Situacao).HasMaxLength(10).HasDefaultValue("Ativo");
            builder.Property(p => p.NumeroCasa).HasMaxLength(4);
            builder.Property(p => p.RuaId).HasMaxLength(4).IsRequired();
        }
    }
}
