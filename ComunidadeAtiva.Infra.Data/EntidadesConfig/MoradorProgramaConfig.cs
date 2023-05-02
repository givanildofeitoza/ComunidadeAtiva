using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class MoradorProgramaConfig : IEntityTypeConfiguration<MoradorPrograma>
    {
        public void Configure(EntityTypeBuilder<MoradorPrograma> builder)
        {            
            builder.Property(p => p.Ativo).HasMaxLength(1).HasDefaultValue("S");
            builder.Property(p => p.ProgramaId).HasMaxLength(3).IsRequired();
            builder.Property(p => p.MoradorId).HasMaxLength(6).IsRequired();
        }
    }
}
