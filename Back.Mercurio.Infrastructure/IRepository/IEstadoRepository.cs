using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IEstadoRepository
    {
        Task<IEnumerable<Estado>> ObterTodos();
        Task<Estado> ObterPorId(Guid idEstado);
        Task<bool> Adicionar(Estado estado);
    }
}
