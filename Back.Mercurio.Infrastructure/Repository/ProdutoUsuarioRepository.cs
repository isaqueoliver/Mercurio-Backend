﻿using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.Context;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.Repository
{
    public class ProdutoUsuarioRepository : IProdutoUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoUsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<ProdutoUsuario>> ObterTodosPorUsuario(Guid usuarioId)
        {
            return await _context.ProdutoUsuarios.Where(x => x.UsuarioCriacao == usuarioId &&
                                                             x.DataExclusao != null).ToListAsync();
        }

        public async Task<IEnumerable<ProdutoUsuario>> ObterTodosPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            return await _context.ProdutoUsuarios.Where(x => x.EstadoId == estadoId &&
                                                             x.CidadeId == cidadeId &&
                                                             x.DataExclusao != null).ToListAsync();
        }

        public async Task<IEnumerable<ProdutoUsuario>> ObterTodosPorMercado(Guid mercadoId)
        {
            return await _context.ProdutoUsuarios.Where(x => x.MercadoId == mercadoId &&
                                                             x.DataExclusao != null).ToListAsync();
        }
    }
}
