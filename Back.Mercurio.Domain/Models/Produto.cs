using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class Produto : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string? Categoria { get; private set; }
        public string? Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public string? Imagem { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string UsuarioCadastro { get; private set; }

        public Guid IdMercado { get; private set; }
        public virtual Mercado Mercado { get; private set; }
        public virtual List<ProdutoUsuario> ProdutoUsuarios { get; private set; }

        public Produto() { }

        public Produto(string nome, decimal valor, Mercado mercado, string? imagem)
        {
            Nome = nome;
            Valor = valor;
            Mercado = mercado;
            Imagem = imagem;
            Ativo = true;
            DataCadastro = DateTime.Now;
        }
    }
}
