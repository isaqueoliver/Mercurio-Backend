using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface ICarrinhoRepository
    {
        Task<bool> Adicionar(CarrinhoCliente carrinho);
        Task<bool> RemoverCarrinho(CarrinhoCliente carrinho);
        Task<bool> Atualizar(CarrinhoCliente carrinho);
        Task<bool> AdicionarItem(CarrinhoItem item);
        Task<bool> RemoverItemCarrinho(CarrinhoItem carrinhoItem);
        Task<bool> AtualizarItem(CarrinhoItem item);
        Task<CarrinhoCliente> ObterCarrinhoCliente(Guid userId);
        Task<CarrinhoItem> ObterCarrinhoItem(Guid carrinhoId, Guid produtoId);
    }
}
