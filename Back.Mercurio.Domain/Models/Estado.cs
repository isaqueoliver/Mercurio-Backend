using Back.Mercurio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Domain.Models
{
    public class Estado : Entity
    {
        public string Sigla { get; private set; }

        public virtual List<Cidade> Cidades { get; private set; }
        public virtual List<Mercado> Mercados { get; private set; }

        public Estado() { }

        public Estado(string sigla)
        {
            Sigla = sigla;
        }

        public Estado(Guid id, string sigla)
        {
            Id = id;
            Sigla = sigla;
        }
    }
}
