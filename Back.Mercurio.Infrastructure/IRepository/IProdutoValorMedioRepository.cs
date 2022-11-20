using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IProdutoValorMedioRepository
    {
        Task<bool> Adicionar(ProdutoValorMedio produto);
        Task<bool> Atualizar(ProdutoValorMedio produto);
        Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorEstadoECidade(Guid cidadeId);
        Task<IEnumerable<Guid>> ObterTodosMercadosPorCidade(Guid cidadeId);
        Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorMercado(Guid mercadoId);
        Task<ProdutoValorMedio> ObterPorMercadoEProduto(Guid mercadoId, Guid produtoId);
        Task<IEnumerable<ProdutoValorMedio>> ObterProdutosPorNome(string nome);
        Task<ProdutoValorMedio> ObterProdutoMaisBartoPorEstadoECidade(Guid cidadeId, Guid produtoId);
    }
}
