using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Api.Models
{
    public struct ItemCarrinhoViewModel
    {
        public Guid ProdutoId { get; set; }
        public Guid MercadoId { get; set; }

        public ItemCarrinhoViewModel(Guid produtoId, Guid mercadoId)
        {
            ProdutoId = produtoId;
            MercadoId = mercadoId;
        }
    }
}
