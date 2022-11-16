using Back.Mercurio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IProdutoUsuarioRepository
    {
        Task<IEnumerable<ProdutoUsuario>> ObterTodosPorUsuario(Guid usuarioId);
        Task<IEnumerable<ProdutoUsuario>> ObterTodosPorMercadoEProduto(Guid mercadoId, Guid produtoId);
        Task<IEnumerable<ProdutoUsuario>> ObterTodosPorEstadoECidade(Guid estadoId, Guid cidadeId);
        Task<IEnumerable<ProdutoUsuario>> ObterTodosPorMercado(Guid mercadoId);
        Task<bool> Adicionar(ProdutoUsuario produto);
        Task<IEnumerable<ProdutoUsuario>> ObterProdutosPorNome(string nome);
    }
}
