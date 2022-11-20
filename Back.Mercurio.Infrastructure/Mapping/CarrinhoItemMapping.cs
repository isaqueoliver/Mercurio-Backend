using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class CarrinhoItemMapping : IEntityTypeConfiguration<CarrinhoItem>
    {
        public void Configure(EntityTypeBuilder<CarrinhoItem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.Itens)
                .HasForeignKey(x => x.ProdutoId);

            builder.Property(x => x.Nome)
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .IsRequired();

            builder.Property(x => x.Valor)
                .IsRequired();

            builder.Property(x => x.Imagem)
                .IsRequired();

            builder.HasOne(x => x.CarrinhoCliente)
                .WithMany(x => x.Itens)
                .HasForeignKey(x => x.CarrinhoClienteId);
        }
    }
}
