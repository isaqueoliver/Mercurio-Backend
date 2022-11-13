namespace Back.Mercurio.Api.Models
{
    public struct CidadeViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public CidadeViewModel(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
