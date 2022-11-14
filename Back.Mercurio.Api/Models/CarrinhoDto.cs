using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Api.Models
{
    public class CarrinhoDto
    {
        public decimal ValorTotal { get; set; }
        public string Mercado { get; set; }
        public List<CarrinhoItem> Itens { get; set; } = new List<CarrinhoItem>();

        public CarrinhoDto(decimal valorTotal, string mercado, List<CarrinhoItem> itens)
        {
            ValorTotal = valorTotal;
            Mercado = mercado;
            Itens = itens;
        }
    }
}
