using Back.Mercurio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IProdutoValorMedioRepository
    {
        Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorEstadoECidade(Guid estadoId, Guid cidadeId);
        Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorMercado(Guid mercadoId);
    }
}
