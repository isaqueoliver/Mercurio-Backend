using Back.Mercurio.Api.Models;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    public class AssuntoController : MainController
    {
        private readonly IAssuntoRepository _assuntoRepository;

        public AssuntoController(IAssuntoRepository assuntoRepository)
        {
            _assuntoRepository = assuntoRepository;
        }

        /// <summary>
        /// Método para obter todos os Assuntos
        /// </summary>
        [HttpGet("ObterTodos")]
        [ProducesResponseType(typeof(IEnumerable<Assunto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<Assunto>>> ObterTodos()
        {
            try
            {
                var assuntos = await _assuntoRepository.ObterTodos();
                if (assuntos is not null && assuntos.Any())
                {
                    return Ok(assuntos.AssuntoMapToAssuntoViewModel());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }
    }
}
