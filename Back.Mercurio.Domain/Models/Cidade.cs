using Back.Mercurio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Domain.Models
{
    public class Cidade : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }

        public Guid EstadoId { get; private set; }
        public virtual Estado Estado { get; private set; }

        public Cidade() { }

        public Cidade(string nome, Estado estado)
        {
            Estado = estado;
            Nome = nome;
        }
    }
}
