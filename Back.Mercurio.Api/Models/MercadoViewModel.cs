namespace Back.Mercurio.Api.Models
{
    public class MercadoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid EstadoId { get; set; }
        public Guid CidadeId { get; set; }
        public string Endereco { get; set; }

        public MercadoViewModel(Guid id, string nome, Guid estadoId, Guid cidadeId, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            EstadoId = estadoId;
            CidadeId = cidadeId;
        }
    }
}
