using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class Mercado : EntityBase
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public virtual List<Produto> Produtos { get; private set; }
        public virtual List<ProdutoUsuario> ProdutosUsuarios { get; private set; }

        public Mercado(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Ativo = true;
            DataCadastro = DateTime.Now;
        }
    }
}
