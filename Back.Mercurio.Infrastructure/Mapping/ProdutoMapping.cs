using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Categoria)
                .IsRequired(false)
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Descricao)
                .IsRequired(false)
                .HasColumnType("varchar(500)");

            builder.Property(x => x.Imagem)
                .IsRequired(false)
                .HasColumnType("varchar(250)");

            //builder.Property(x => x.IdMercado)
            //    .IsRequired();

            builder.HasOne(x => x.Mercado)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.IdMercado);

            builder.ToTable("Produtos");
        }
    }
}
