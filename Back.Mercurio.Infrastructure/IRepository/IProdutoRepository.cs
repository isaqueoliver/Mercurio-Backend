﻿using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);
        Task<IEnumerable<Produto>> ObterProdutosPorNome(string nome);

        Task<bool> Adicionar(Produto produto);
        void Atualizar(Produto produto);
    }
}
