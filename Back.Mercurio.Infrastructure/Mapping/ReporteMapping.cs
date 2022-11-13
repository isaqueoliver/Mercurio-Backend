using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.Mapping
{
    public class ReporteMapping : IEntityTypeConfiguration<Reporte>
    {
        public void Configure(EntityTypeBuilder<Reporte> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(x => x.Resposta)
                .IsRequired(false)
                .HasColumnType("varchar(500)");

            builder.Property(x => x.Status)
                .IsRequired();

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

            builder.HasOne(x => x.Assunto)
                .WithMany(x => x.Reportes)
                .HasForeignKey(x => x.AssuntoId);

            builder.ToTable("Reportes");
        }
    }
}
