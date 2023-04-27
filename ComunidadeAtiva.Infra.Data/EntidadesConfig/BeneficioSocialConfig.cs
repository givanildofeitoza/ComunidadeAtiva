using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class BeneficioSocialConfig : IEntityTypeConfiguration<BeneficioSocial>
    {
        public void Configure(EntityTypeBuilder<BeneficioSocial> builder)
        {     
            
            builder.Property(p => p.DescricaoBeneficioSocial).HasMaxLength(200);
            builder.Property(p => p.NomeBeneficioSocial).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Ativo).HasMaxLength(1).HasDefaultValue("S").IsRequired();
            
        }
    }
}
