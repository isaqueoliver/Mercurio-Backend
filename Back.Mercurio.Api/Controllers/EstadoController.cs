using Back.Mercurio.Api.Models;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    public class EstadoController : MainController
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoController(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        /// <summary>
        /// Método para obter todos os Estados
        /// </summary>
        [HttpGet("ObterTodos")]
        [ProducesResponseType(typeof(IEnumerable<Estado>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<Estado>>> ObterTodos()
        {
            try
            {
                var estados = await _estadoRepository.ObterTodos();
                if (estados is not null && estados.Any())
                {
                    return Ok(estados);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpPost("Adicionar")]
        [ProducesResponseType(typeof(Estado), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> AdicionarEstado([FromBody, Required] EstadoViewModel estado)
        {
            try
            {
                var estadoAdd = new Estado(estado.Sigla);
                var result = await _estadoRepository.Adicionar(estadoAdd);

                if (result)
                {
                    return Created("Estado adicionado com sucesso!", estadoAdd);
                }

                AdicionarErroProcessamento("Erro ao adicionar o estado");
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }
    }
}
