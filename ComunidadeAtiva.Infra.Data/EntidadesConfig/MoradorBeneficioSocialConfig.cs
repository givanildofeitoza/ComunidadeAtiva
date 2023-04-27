using ComunidadeAtiva.Dominio.Entidades;
using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class MoradorBeneficioSocialConfig : IEntityTypeConfiguration<MoradorBeneficioSocial>
    {
        public void Configure(EntityTypeBuilder<MoradorBeneficioSocial> builder)
        {            
            builder.Property(p => p.Ativo).HasMaxLength(1).HasDefaultValue("S").IsRequired();
            builder.Property(p => p.IdMorador).HasMaxLength(4).IsRequired();
            builder.Property(p => p.IdBeneficioSocial).HasMaxLength(4).IsRequired();
            builder.Property(p => p.Valor).HasPrecision(8,2).HasDefaultValue(0.00);
        }
    }
}
