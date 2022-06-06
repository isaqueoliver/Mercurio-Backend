using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IMercadoRepository : IRepository<Mercado>
    {
        Task<IEnumerable<Mercado>> ObterTodos();
        Task<Mercado> ObterPorNome(string nome);
        Task<Mercado> ObterPorId(Guid id);
        Task<bool> Adicionar(Mercado mercado);
        void Atualizar(Mercado mercado);
    }
}