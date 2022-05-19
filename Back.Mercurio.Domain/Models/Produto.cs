using Back.Mercurio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Domain.Models
{
    public class Produto : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Imagem { get; set; }

        public string IdMercado { get; set; }
        public  Mercado Mercado { get; set; }

        internal ProdutoViewModel ParaViewModel()
        {
            return new ProdutoViewModel(this.Id, this.Nome, this.Categoria, this.Descricao, this.Valor, this.Imagem, this.Mercado.Nome);
        }
    }
}
