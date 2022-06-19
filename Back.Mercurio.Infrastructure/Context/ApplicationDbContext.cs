using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<CarrinhoItem> CarrinhoItens { get; set; }
        public DbSet<CarrinhoCliente> CarrinhoCliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarrinhoCliente>()
                        .HasIndex(x => x.ClienteId)
                        .HasDatabaseName("IDX_Cliente");

            modelBuilder.Entity<CarrinhoCliente>()
                        .HasMany(x => x.Itens)
                        .WithOne(y => y.CarrinhoCliente)
                        .HasForeignKey(x => x.CarrinhoId);

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
