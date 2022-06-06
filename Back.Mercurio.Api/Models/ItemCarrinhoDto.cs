using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Api.Models
{
    public class ItemCarrinhoDto
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Imagem { get; set; }
        public int Quantidade { get; set; }

        public ItemCarrinhoDto(Guid produtoId, string nome, decimal valor, string imagem, int quantidade)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Valor = valor;
            Imagem = imagem;
            Quantidade = quantidade;
        }

        internal CarrinhoItem ParaCarrinhoItem()
        {
            return new CarrinhoItem(ProdutoId, Nome, Quantidade, Valor, Imagem);
        }
    }
}
