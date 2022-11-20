using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class EstadoMapping : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Sigla)
                .IsRequired()
                .HasColumnType("varchar(2)");

            builder.HasMany(x => x.Cidades)
                .WithOne(x => x.Estado);

            builder.ToTable("Estados");
        }
    }
}
