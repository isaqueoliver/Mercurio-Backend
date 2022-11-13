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
                .HasColumnType("varchar(250)");

            builder.HasOne(x => x.Estado)
                .WithMany(x => x.Mercados)
                .HasForeignKey(x => x.EstadoId);

            builder.HasOne(x => x.Cidade)
                .WithMany(x => x.Mercados)
                .HasForeignKey(x => x.CidadeId);

            builder.Property(x => x.DataCriacao)
                .IsRequired();

            builder.Property(x => x.UsuarioCriacao)
                .IsRequired()
                .HasColumnType("varchar(36)");

            builder.Property(x => x.DataAlteracao)
                .IsRequired(false);

            builder.Property(x => x.UsuarioAlteracao)
                .IsRequired(false)
                .HasColumnType("varchar(36)");

            builder.Property(x => x.DataExclusao)
                .IsRequired(false);

            builder.Property(x => x.UsuarioExclusao)
                .IsRequired(false)
                .HasColumnType("varchar(36)");

            builder.ToTable("Mercados");
        }
    }
}
