using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class ProdutoValorMedioMapping : IEntityTypeConfiguration<ProdutoValorMedio>
    {
        public void Configure(EntityTypeBuilder<ProdutoValorMedio> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.ProdutosValoresMedios)
                .HasForeignKey(x => x.ProdutoId);

            builder.HasOne(x => x.Mercado)
                .WithMany(x => x.ProdutosValoresMedios)
                .HasForeignKey(x => x.MercadoId);

            builder.Property(x => x.EstadoId)
                .IsRequired()
                .HasColumnType("varchar(36)");

            builder.Property(x => x.CidadeId)
                .IsRequired()
                .HasColumnType("varchar(36)");

            builder.Property(x => x.Valor);

            builder.Property(x => x.Ativo);

            builder.Property(x => x.DataCriacao);

            builder.Property(x => x.DataAlteracao);

            builder.ToTable("ProdutosValoresMedios");
        }
    }
}
