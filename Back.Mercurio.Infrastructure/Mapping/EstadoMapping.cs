using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
