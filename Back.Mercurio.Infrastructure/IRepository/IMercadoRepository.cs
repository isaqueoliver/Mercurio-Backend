using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IMercadoRepository
    {
        Task<IEnumerable<Mercado>> ObterTodosPorEstadoECidade(Guid estadoId, Guid cidadeId);
        Task<Mercado> ObterPorNome(string nome);
        Task<Mercado> ObterPorId(Guid id);
        Task<bool> Adicionar(Mercado mercado);
        void Atualizar(Mercado mercado);
        Task<bool> Remover(Mercado mercado);
    }
}