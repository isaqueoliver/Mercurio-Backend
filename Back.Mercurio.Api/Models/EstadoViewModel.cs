namespace Back.Mercurio.Api.Models
{
    public class EstadoViewModel
    {
        public string Sigla { get; set; }

        public EstadoViewModel(string sigla)
        {
            Sigla = sigla;
        }
    }
}
