using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class MercadoMapping : IEntityTypeConfiguration<Mercado>
    {
        public void Configure(EntityTypeBuilder<Mercado> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Endereco)
                .IsRequired(false)
                .HasColumnType("varchar(500)");

            builder.HasMany(x => x.Produtos)
                .WithOne(x => x.Mercado);

            builder.ToTable("Mercados");
        }
    }
}
