using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Api.Models
{
    public class CarrinhoDto
    {
        public decimal ValorTotal { get; set; }
        public string Mercado { get; set; }
        public List<ItemCarrinhoDto> Itens { get; set; } = new List<ItemCarrinhoDto>();

        public CarrinhoDto(decimal valorTotal, string mercado, List<CarrinhoItem> itens)
        {
            ValorTotal = valorTotal;
            Mercado = mercado;
            CarrinhoItemParaItemCarrinhoDto(itens);
        }

        internal void CarrinhoItemParaItemCarrinhoDto(List<CarrinhoItem> itens)
        {
            if(itens is not null && itens.Any()) Itens = itens.Select(x => new ItemCarrinhoDto(x.ProdutoId, x.Nome, x.Valor, x.Imagem, x.Quantidade)).ToList();
        }
    }
}
