using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IMercadoRepository : IRepository<Mercado>
    {
        Task<IEnumerable<Mercado>> ObterTodos();
        Task<Mercado> ObterPorNome(string nome);
        Task<Mercado> ObterPorId(Guid id);
        void Adicionar(Mercado mercado);
        void Atualizar(Mercado mercado);
    }
}