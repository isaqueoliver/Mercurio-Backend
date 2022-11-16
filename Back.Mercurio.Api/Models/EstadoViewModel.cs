namespace Back.Mercurio.Api.Models
{
    public struct EstadoViewModel
    {
        public string Sigla { get; set; }

        public EstadoViewModel(string sigla)
        {
            Sigla = sigla;
        }
    }
}
