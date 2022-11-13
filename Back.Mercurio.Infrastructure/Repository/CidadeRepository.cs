using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
