namespace Back.Mercurio.Api.Models
{
    public struct ProdutoValorMedioModelView
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public Guid MercadoId { get; set; }
        public string Mercado { get; set; }
        public string? Imagem { get; set; }
        public decimal Valor { get; set; }

        public ProdutoValorMedioModelView(Guid produtoId, string nome, Guid mercadoId, string mercado, string? imagem, decimal valor)
        {
            ProdutoId = produtoId;
            Nome = nome;
            MercadoId = mercadoId;
            Mercado = mercado;
            Imagem = imagem;
            Valor = valor;
        }
    }

    public struct ProdutoValorMedioViewModel
    {
    }
}
