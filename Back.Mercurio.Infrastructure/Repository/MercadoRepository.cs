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

        public async Task<IEnumerable<Mercado>> ObterTodosPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            return await _context.Mercados.Include(x => x.Estado).Include(x => x.Cidade)
                                          .AsNoTracking().Where(x => x.EstadoId == estadoId &&
                                                                     x.CidadeId == cidadeId &&
                                                                     x.DataExclusao == null).ToListAsync();
        }

        public async Task<IEnumerable<Mercado>> ObterMercadosPorNome(string nome)
        {
            return await _context.Mercados.Include(x => x.Estado).Include(x => x.Cidade).Where(x => x.Nome.Contains(nome)).ToListAsync();
        }

        public async Task<Mercado> ObterPorId(Guid id)
        {
            return await _context.Mercados.FindAsync(id);
        }

        public async Task<bool> Adicionar(Mercado mercado)
        {
            _context.Mercados.Add(mercado);
            return await _context.Commit();
        }

        public void Atualizar(Mercado mercado)
        {
            _context.Mercados.Update(mercado);
        }

        public async Task<bool> Remover(Mercado mercado)
        {
            _context.Mercados.Remove(mercado);
            return await _context.Commit();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
