using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IAssuntoRepository
    {
        Task<IEnumerable<Assunto>> ObterTodos();
    }
}
