using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly ApplicationDbContext _context;

        public CarrinhoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Adicionar(CarrinhoCliente carrinho)
        {
            _context.CarrinhoCliente.Add(carrinho);
            return await _context.Commit();
        }

        public async Task<bool> RemoverItemCarrinho(CarrinhoItem carrinhoItem)
        {
            _context.CarrinhoItens.Remove(carrinhoItem);
            return await _context.Commit();
        }

        public async Task<bool> RemoverCarrinho(CarrinhoCliente carrinho)
        {
            _context.CarrinhoCliente.Remove(carrinho);
            return await _context.Commit();
        }

        public async Task<bool> Atualizar(CarrinhoCliente carrinho)
        {
            _context.CarrinhoCliente.Update(carrinho);
            return await _context.Commit();
        }

        public async Task<bool> AdicionarItem(CarrinhoItem item)
        {
            _context.CarrinhoItens.Add(item);
            return await _context.Commit();
        }

        public async Task<bool> AtualizarItem(CarrinhoItem item)
        {
            _context.CarrinhoItens.Update(item);
            return await _context.Commit();
        }

        public async Task<CarrinhoCliente> ObterCarrinhoCliente(Guid userId)
        {
            return await _context.CarrinhoCliente
                                 .Include(x => x.Itens)
                                 .FirstOrDefaultAsync(x => x.ClienteId == userId);
        }

        public async Task<CarrinhoItem> ObterCarrinhoItem(Guid carrinhoId, Guid produtoId)
        {
            return await _context.CarrinhoItens
                                 .FirstOrDefaultAsync(x => x.CarrinhoId == carrinhoId && x.ProdutoId == produtoId);
        }
    }
}
