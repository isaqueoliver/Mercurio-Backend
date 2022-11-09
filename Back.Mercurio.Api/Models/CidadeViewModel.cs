namespace Back.Mercurio.Api.Models
{
    public class CidadeViewModel
    {
        public Guid IdEstado { get; set; }
        public string Nome { get; set; }

        public CidadeViewModel(string nome, Guid idEstado)
        {
            Nome = nome;
            IdEstado = idEstado;
        }
    }
}
