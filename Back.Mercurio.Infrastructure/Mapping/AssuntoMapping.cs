using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class AssuntoMapping : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Ativo)
                .IsRequired();

            builder.ToTable("Assuntos");
        }
    }
}
