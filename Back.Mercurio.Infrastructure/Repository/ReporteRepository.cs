using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Repository
{
    public class ReporteRepository : IReporteRepository
    {
        private readonly ApplicationDbContext _context;

        public ReporteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;


        public async Task<IEnumerable<Reporte>> ObterTodosPorUsuarioId(Guid usuarioId)
        {
            return await _context.Reportes.Include(x => x.Assunto).AsNoTracking().Where(x => x.UsuarioCriacao == usuarioId &&
                                                                     x.DataExclusao == null
                                                               ).ToListAsync();
        }

        public async Task<Reporte> ObterPorId(Guid reporteId)
        {
            return await _context.Reportes.AsNoTracking().SingleOrDefaultAsync(x => x.Id == reporteId &&
                                                                     x.DataExclusao == null
                                                               );
        }

        public async Task<bool> Adicionar(Reporte reporte)
        {
            _context.Reportes.Add(reporte);
            return await _context.Commit();
        }

        public async Task<bool> Atualizar(Reporte reporte)
        {
            _context.Reportes.Update(reporte);
            return await _context.Commit();
        }

        public async Task<bool> Remover(Reporte reporte)
        {
            _context.Reportes.Remove(reporte);
            return await _context.Commit();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
