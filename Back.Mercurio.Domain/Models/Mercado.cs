using Back.Mercurio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Domain.Models
{
    public class Mercado : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
