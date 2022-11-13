using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            return await _context.ProdutosValoresMedios.Where(x => x.EstadoId == estadoId &&
                                                                   x.CidadeId == cidadeId &&
                                                                   x.Ativo).ToListAsync();
        }

        public async Task<IEnumerable<ProdutoValorMedio>> ObterTodosPorMercado(Guid mercadoId)
        {
            return await _context.ProdutosValoresMedios.Where(x => x.MercadoId == mercadoId &&
                                                                   x.Ativo).ToListAsync();
        }
    }
}
