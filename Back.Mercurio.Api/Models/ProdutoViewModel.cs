namespace Back.Mercurio.Api.Models
{
    public struct ProdutoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string? Imagem { get; set; }

        public ProdutoViewModel(Guid id, string nome, string? imagem)
        {
            Id = id;
            Nome = nome;
            Imagem = imagem;
        }
    }
}
