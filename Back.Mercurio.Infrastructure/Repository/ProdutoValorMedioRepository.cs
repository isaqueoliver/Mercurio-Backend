using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Back.Mercurio.Infrastructure.Repository
{
    public class ProdutoValorMedioRepository : IProdutoValorMedioRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoValorMedioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<bool> Adicionar(ProdutoValorMedio produto)
        {
            _context.ProdutosValoresMedios.Add(produto);
            return await _context.Commit();
        }

        public async Task<bool> Atualizar(ProdutoValorMedio produto)
        {
            _context.ProdutosValoresMedios.Update(produto);
            return await _context.Commit();
        }
        public async Task<IEnumerable<Guid>> ObterTodosMercadosPorCidade(Guid cidadeId)
        {
            return _context.ProdutosValoresMedios.Where(x => x.CidadeId == cidadeId &&
                                                             x.Ativo).Select(x => x.MercadoId);
        }

        public async Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorEstadoECidade(Guid cidadeId)
        {
            return await _context.ProdutosValoresMedios.Include(x => x.Mercado)
                                                       .Include(x => x.Produto)
                                                       .Where(x => x.CidadeId == cidadeId &&
                                                                   x.Ativo)
                                                       .ToListAsync();
        }

        public async Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorMercado(Guid mercadoId)
        {
            return await _context.ProdutosValoresMedios.Include(x => x.Mercado).Include(x => x.Produto).Where(x => x.MercadoId == mercadoId &&
                                                                   x.Ativo).ToListAsync();
        }

        public async Task<ProdutoValorMedio> ObterPorMercadoEProduto(Guid mercadoId, Guid produtoId)
        {
            return await _context.ProdutosValoresMedios.Include(x => x.Mercado)
                                                       .Include(x => x.Produto)
                                                       .SingleOrDefaultAsync(x => x.MercadoId == mercadoId &&
                                                                                  x.ProdutoId == produtoId &&
                                                                                  x.Ativo);
        }

        public async Task<ProdutoValorMedio> ObterProdutoMaisBartoPorEstadoECidade(Guid cidadeId, Guid produtoId)
        {
            return await _context.ProdutosValoresMedios.Include(x => x.Mercado)
                                                       .Include(x => x.Produto)
                                                       .Where(x => x.CidadeId == cidadeId &&
                                                                   x.ProdutoId == produtoId &&
                                                                   x.Ativo)
                                                       .OrderBy(x => x.Valor).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProdutoValorMedio>> ObterProdutosPorNome(string nome)
        {
            return await _context.ProdutosValoresMedios.Include(x => x.Mercado).Include(x => x.Produto).Where(x => x.Produto.Nome.Contains(nome) && x.Ativo).ToListAsync();
        }
    }
}
