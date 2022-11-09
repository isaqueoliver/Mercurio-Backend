using Back.Mercurio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IReporteRepository
    {
        Task<IEnumerable<Reporte>> ObterTodosPorUsuarioId(Guid usuarioId);
        Task<bool> Adicionar(Reporte reporte);
        Task<bool> Atualizar(Reporte reporte);
        Task<bool> Remover(Reporte reporte);
    }
}
