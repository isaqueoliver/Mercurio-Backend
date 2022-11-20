using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class CarrinhoClienteMapping : IEntityTypeConfiguration<CarrinhoCliente>
    {
        public void Configure(EntityTypeBuilder<CarrinhoCliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.ClienteId)
                .HasDatabaseName("IDX_Cliente");

            builder.Property(x => x.ValorTotal)
                .IsRequired();

            builder.HasOne(x => x.Mercado)
                .WithMany(x => x.Carrinhos)
                .HasForeignKey(x => x.MercadoId);

            builder.HasMany(x => x.Itens)
                .WithOne(x => x.CarrinhoCliente)
                .HasForeignKey(x => x.CarrinhoClienteId);
        }
    }
}
