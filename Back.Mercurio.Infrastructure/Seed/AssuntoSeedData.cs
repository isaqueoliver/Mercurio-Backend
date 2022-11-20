using Back.Mercurio.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Seed
{
    public static class AssuntoSeedData
    {
        public static void CreateAssunto(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assunto>().HasData(
                new Assunto(new Guid("40fe795e-c60e-4afb-abf0-07c0c599d1d0"), "Falta o nome de um Supermercado ou Mercado", true),
                new Assunto(new Guid("ce6b710e-1740-471a-b2ae-899cd2e433c8"), "Falta o nome de um Produto ou informação do Produto", true)
            );
        }
    }
}
