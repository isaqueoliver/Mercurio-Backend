namespace Back.Mercurio.Api.Models
{
    public class MercadoViewModel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public MercadoViewModel(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
