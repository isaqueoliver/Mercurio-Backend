using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface ICidadeRepository
    {
        Task<IEnumerable<Cidade>> ObterTodasCidadesPorEstadoId(Guid estadoId);
        Task<Cidade> ObterPorId(Guid cidadeId);
    }
}
