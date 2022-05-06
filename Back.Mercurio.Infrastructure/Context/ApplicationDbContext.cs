using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;

            return sucesso;
        }
    }
}
