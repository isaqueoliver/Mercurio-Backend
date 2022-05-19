using Back.Mercurio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface MercadoRepository : IRepository<Mercado>
    {
        Task<IEnumerable<Mercado>> ObterTodos();
        Task<Mercado> ObterPorId(Guid id);

        void Adicionar(Mercado mercado);
        void Atualizar(Mercado mercado);
    }
}
