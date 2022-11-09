using Back.Mercurio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface ICidadeRepository : IRepository<Cidade>
    {
        Task<IEnumerable<Cidade>> ObterTodos();
        Task<bool> Adicionar(Cidade cidade);
    }
}
