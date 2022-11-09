using Back.Mercurio.Domain.Models;

namespace Back.Mercurio.Api.Models
{
    public static class MapTo
    {
        public static AssuntoViewModel AssuntoMapToAssuntoViewModel(this Assunto assunto)
        {
            return new AssuntoViewModel { Id = assunto.Id, Descricao = assunto.Descricao };
        }

        public static IEnumerable<AssuntoViewModel> AssuntoMapToAssuntoViewModel(this IEnumerable<Assunto> assuntos)
        {
            foreach(var assunto in assuntos)
            {
                yield return new AssuntoViewModel { Id = assunto.Id, Descricao = assunto.Descricao };
            }
        }
    }
}
