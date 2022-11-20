using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Repository
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly ApplicationDbContext _context;

        public CidadeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Cidade>> ObterTodasCidadesPorEstadoId(Guid estadoId)
        {
            return await _context.Cidades.AsNoTracking().Where(x => x.EstadoId == estadoId).ToListAsync();
        }

        public async Task<Cidade> ObterPorId(Guid cidadeId)
        {
            return await _context.Cidades.AsNoTracking().SingleOrDefaultAsync(x => x.Id == cidadeId);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
