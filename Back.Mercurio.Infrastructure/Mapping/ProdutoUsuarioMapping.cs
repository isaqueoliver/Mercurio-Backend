using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class ProdutoUsuarioMapping : IEntityTypeConfiguration<ProdutoUsuario>
    {
        public void Configure(EntityTypeBuilder<ProdutoUsuario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.ProdutoUsuarios)
                .HasForeignKey(x => x.ProdutoId);

            builder.HasOne(x => x.Mercado)
                .WithMany(x => x.ProdutosUsuarios)
                .HasForeignKey(x => x.MercadoId);

            builder.Property(x => x.EstadoId)
                .IsRequired()
                .HasColumnType("varchar(36)");

            builder.Property(x => x.CidadeId)
                .IsRequired()
                .HasColumnType("varchar(36)");

            builder.Property(x => x.Valor);

            builder.Property(x => x.Ativo)
                .IsRequired();

            builder.ToTable("ProdutosUsuarios");
        }
    }
}
