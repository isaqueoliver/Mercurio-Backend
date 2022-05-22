using Back.Mercurio.Api.Models;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    public class MercadoController : MainController
    {
        private readonly IMercadoRepository _mercadoRepository;
        public MercadoController(IMercadoRepository mercadoRepository)
        {
            _mercadoRepository = mercadoRepository;
        }

        /// <summary>
        /// Método para obter todos os Mercados
        /// </summary>
        [HttpGet("ObterTodos")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<MercadoViewModel>>> ObterTodos()
        {
            try
            {
                var result = ParaMercadoViewModel(await _mercadoRepository.ObterTodos());
                if (result is not null && result.Any())
                {
                    return Ok(result);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        private static IEnumerable<MercadoViewModel> ParaMercadoViewModel(IEnumerable<Mercado> mercados)
        {
            return mercados.Select(x => new MercadoViewModel(x.Nome, x.Endereco));
        }
    }
}
