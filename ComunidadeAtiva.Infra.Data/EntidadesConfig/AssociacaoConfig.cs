using ComunidadeAtiva.Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ComunidadeAtiva.Infra.Data.EntidadesConfig
{
    public class AssociacaoConfig : IEntityTypeConfiguration<Associacao>
    {
        public void Configure(EntityTypeBuilder<Associacao> builder)
        {            
            builder.Property(p => p.Endereco).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Bairro).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Cnpj).HasMaxLength(15).IsRequired();
            builder.Property(p => p.Representante1).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Representante2).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Estado).HasMaxLength(2).IsRequired();
            builder.Property(p => p.AnoPosse).HasMaxLength(4).IsRequired();
            builder.Property(p => p.AnoFimMandato).HasMaxLength(4).IsRequired();            
            builder.Property(p => p.Celular).HasMaxLength(15);
            builder.Property(p => p.Cidade).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(30);
            builder.Property(p => p.Telefone).HasMaxLength(15);
            builder.Property(p => p.NomeFantasia).HasMaxLength(50).IsRequired();
            builder.Property(p => p.RazaoSocial).HasMaxLength(50).IsRequired();
            builder.Property(p => p.site).HasMaxLength(50).IsRequired();

        }
    }
}
