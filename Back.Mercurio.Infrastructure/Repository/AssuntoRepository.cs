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
    public class AssuntoRepository : IAssuntoRepository
    {
        private readonly ApplicationDbContext _context;

        public AssuntoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;


        public async Task<IEnumerable<Assunto>> ObterTodos()
        {
            return await _context.Assuntos.AsNoTracking().Where(x => x.Ativo).ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
