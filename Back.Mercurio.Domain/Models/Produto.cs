using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class Produto : EntityBase
    {
        public string Nome { get; private set; }
        public string? Imagem { get; private set; }
        public DateTime? DataAlteracao { get; private set; }
        public Guid? UsuarioAlteracao { get; private set; }

        public virtual List<ProdutoUsuario> ProdutoUsuarios { get; private set; }
        public virtual List<ProdutoValorMedio> ProdutosValoresMedios { get; private set; }
        public virtual List<CarrinhoItem> Itens { get; private set; }

        public Produto() { }

        public Produto(string nome, string? imagem)
        {
            Nome = nome;
            Imagem = imagem;
            DataCriacao = DateTime.Now;
        }
    }
}
