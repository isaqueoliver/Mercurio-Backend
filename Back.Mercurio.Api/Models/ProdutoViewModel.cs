namespace Back.Mercurio.Api.Models
{
    public class ProdutoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Mercado { get; set; }
        public decimal Valor { get; set; }
        public string? Imagem { get; set; }

        public ProdutoViewModel(Guid id, string nome, string mercado, decimal valor, string? imagem)
        {
            Id = id;
            Nome = nome;
            Mercado = mercado;
            Valor = valor;
            Imagem = imagem;
        }
    }
}
