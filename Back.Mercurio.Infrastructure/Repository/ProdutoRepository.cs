using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _context.Produtos.AsNoTracking().Include(x => x.Mercado).ToListAsync();
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _context.Produtos.Include(x => x.Mercado).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorNome(string nome)
        {
            return await _context.Produtos.AsNoTracking().Include(x => x.Mercado).Where(x => x.Nome == nome).ToListAsync();
        }

        public async Task<bool> Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            return await _context.Commit();
        }

        public async Task<bool> Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
            return await _context.Commit();
        }

        public async Task<bool> Remover(Produto produto)
        {
            _context.Produtos.Remove(produto);
            return await _context.Commit();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
