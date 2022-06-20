namespace Back.Mercurio.Api.Models
{
    public class MercadoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public MercadoViewModel(Guid id, string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}
