using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.Seed
{
    public static class AssuntoSeedData
    {
        public static void CreateAssunto(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assunto>().HasData(
                new Assunto("Falta o nome de um Supermercado ou Mercado", true),
                new Assunto("Falta o nome de um Produto ou informação do Produto", true)
            );
        }
    }
}
