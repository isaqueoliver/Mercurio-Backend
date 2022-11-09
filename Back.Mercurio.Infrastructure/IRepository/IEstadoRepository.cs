using Back.Mercurio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IEstadoRepository : IRepository<Estado>
    {
        Task<IEnumerable<Estado>> ObterTodos();
        Task<Estado> ObterPorId(Guid idEstado);
        Task<bool> Adicionar(Estado estado);
    }
}
