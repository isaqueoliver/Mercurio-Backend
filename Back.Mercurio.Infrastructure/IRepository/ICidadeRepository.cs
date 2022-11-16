﻿using Back.Mercurio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface ICidadeRepository
    {
        Task<IEnumerable<Cidade>> ObterTodasCidadesPorEstadoId(Guid estadoId);
        Task<Cidade> ObterPorId(Guid cidadeId);
    }
}
