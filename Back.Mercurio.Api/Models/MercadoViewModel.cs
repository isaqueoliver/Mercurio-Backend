namespace Back.Mercurio.Api.Models
{
    public struct MercadoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Imagem { get; set; }

        public MercadoViewModel(Guid id, string nome, string estado, string cidade, string endereco, string imagem)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Estado = estado;
            Cidade = cidade;
            Imagem = imagem;
        }
    }

    public struct MercadoDTO
    {
        public string Nome { get; set; }
        public Guid EstadoId { get; set; }
        public Guid CidadeId { get; set; }
        public string Endereco { get; set; }
        public string Imagem { get; set; }

        public MercadoDTO(string nome, Guid estadoId, Guid cidadeId, string endereco, string imagem)
        {
            Nome = nome;
            Endereco = endereco;
            EstadoId = estadoId;
            CidadeId = cidadeId;
            Imagem = imagem;
        }
    }
}
