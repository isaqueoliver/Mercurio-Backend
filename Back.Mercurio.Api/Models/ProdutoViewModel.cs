namespace Back.Mercurio.Api.Models
{
    public class ProdutoViewModel
    {
        public string Nome { get; set; }
        public string Mercado { get; set; }
        public decimal Valor { get; set; }
        public string? Imagem { get; set; }

        public ProdutoViewModel(string nome, string mercado, decimal valor, string? imagem)
        {
            Nome = nome;
            Mercado = mercado;
            Valor = valor;
            Imagem = imagem;
        }
    }
}
