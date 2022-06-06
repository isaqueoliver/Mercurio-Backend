using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class Mercado : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Produto> Produtos { get; set; }

        public Mercado(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Ativo = true;
            DataCadastro = DateTime.Now;
        }
    }
}
