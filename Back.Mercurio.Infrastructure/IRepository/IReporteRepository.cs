using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IReporteRepository
    {
        Task<IEnumerable<Reporte>> ObterTodosPorUsuarioId(Guid usuarioId);
        Task<Reporte> ObterPorId(Guid reporteId);
        Task<bool> Adicionar(Reporte reporte);
        Task<bool> Atualizar(Reporte reporte);
        Task<bool> Remover(Reporte reporte);
    }
}
