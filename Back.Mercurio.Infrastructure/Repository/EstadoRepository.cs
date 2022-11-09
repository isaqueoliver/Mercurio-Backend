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
    public class EstadoRepository : IEstadoRepository
    {
        private readonly ApplicationDbContext _context;

        public EstadoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Estado>> ObterTodos()
        {
            return await _context.Estados.Include(x => x.Cidades).AsNoTracking().ToListAsync();
        }

        public async Task<Estado> ObterPorId(Guid idEstado)
        {
            return await _context.Estados.Include(x => x.Cidades).AsNoTracking().SingleOrDefaultAsync(x => x.Id == idEstado);
        }

        public async Task<bool> Adicionar(Estado estado)
        {
            _context.Estados.Add(estado);
            return await _context.Commit();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
