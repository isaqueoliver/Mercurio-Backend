using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Back.Mercurio.Infrastructure.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoUsuario> ProdutoUsuarios { get; set; }
        public DbSet<ProdutoValorMedio> ProdutosValoresMedios { get; set; }
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<CarrinhoItem> CarrinhoItens { get; set; }
        public DbSet<CarrinhoCliente> CarrinhoCliente { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CreateAssunto();
            modelBuilder.CreateEstado();
            modelBuilder.CreateCidade();

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;

            return sucesso;
        }
    }
}
