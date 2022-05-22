using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Repository
{
    public class MercadoRepository : IMercadoRepository
    {
        private readonly ApplicationDbContext _context;

        public MercadoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Mercado>> ObterTodos()
        {
            return await _context.Mercados.AsNoTracking().ToListAsync();
        }

        public async Task<Mercado> ObterPorNome(string nome)
        {
            return await _context.Mercados.FirstOrDefaultAsync(x => x.Nome == nome);
        }

        public async Task<Mercado> ObterPorId(Guid id)
        {
            return await _context.Mercados.FindAsync(id);
        }

        public void Adicionar(Mercado mercado)
        {
            _context.Mercados.Add(mercado);
        }

        public void Atualizar(Mercado mercado)
        {
            _context.Mercados.Update(mercado);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
