using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class RuaConfig : IEntityTypeConfiguration<Rua>
    {
        public void Configure(EntityTypeBuilder<Rua> builder)
        {            
            builder.Property(p => p.Agua).HasMaxLength(1).HasDefaultValue("S").IsRequired();
            builder.Property(p => p.ColetaLixo).HasMaxLength(1).HasDefaultValue("S").IsRequired();
            builder.Property(p => p.Saneamento).HasMaxLength(1).HasDefaultValue("S").IsRequired();
            builder.Property(p => p.Energia).HasMaxLength(1).HasDefaultValue("S").IsRequired();
            builder.Property(p => p.Calcada).HasMaxLength(1).HasDefaultValue("S").IsRequired();
            builder.Property(p => p.Nome1).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Nome2).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Cep).HasMaxLength(10);        
        }
    }
}
