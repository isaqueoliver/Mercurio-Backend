using Back.Mercurio.Api.Models;
using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Helpers.Helpers
{
    public static class ProdutoHelper
    {
        public static List<ProdutoViewModel> ParaProdutoViewModel(this IEnumerable<Produto> produtos)
        {
            List<ProdutoViewModel> produtoViewModels = new List<ProdutoViewModel>(produtos.Count());
            foreach (var produto in produtos)
            {
                produtoViewModels.Add(new ProdutoViewModel(produto.Nome, produto.Mercado.Nome, produto.Valor, produto.Imagem));
            }
            return produtoViewModels;
        }
    }
}
