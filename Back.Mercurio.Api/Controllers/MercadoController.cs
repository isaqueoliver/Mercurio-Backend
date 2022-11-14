using Back.Mercurio.Api.Models;
using Back.Mercurio.Api.Usuario;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class MercadoController : MainController
    {
        private readonly IMercadoRepository _mercadoRepository;
        private readonly IAspNetUser _user;
        public MercadoController(IMercadoRepository mercadoRepository,
            IAspNetUser user)
        {
            _mercadoRepository = mercadoRepository;
            _user = user;
        }

        /// <summary>
        /// Método para obter todos os Mercados
        /// </summary>
        [HttpGet("ObterPorEstadoECidade/{estadoId}/{cidadeId}")]
        [ProducesResponseType(typeof(IEnumerable<MercadoViewModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<MercadoViewModel>>> ObterTodosPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            try
            {
                var result = await _mercadoRepository.ObterTodosPorEstadoECidade(estadoId, cidadeId);
                if (result.Any())
                {
                    return Ok(result.MercadoMapToMercadoViewModel());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpPost("Adicionar")]
        [ProducesResponseType(typeof(Mercado), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> Adicionar([FromBody, Required] MercadoDTO mercado)
        {
            try
            {
                var mercadoAdd = new Mercado(mercado.Nome, mercado.EstadoId, mercado.CidadeId, mercado.Endereco, mercado.Imagem);
                var result = await _mercadoRepository.Adicionar(mercadoAdd);

                if (result)
                {
                    return Created("Mercado criado com sucesso!", mercadoAdd);
                }

                AdicionarErroProcessamento("Erro ao adicionar um Mercado.");
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpDelete("Remover/{mercadoId}")]
        [ProducesResponseType(typeof(Mercado), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> Remover(Guid mercadoId)
        {
            try
            {
                var mercado = await _mercadoRepository.ObterPorId(mercadoId);

                if (mercado is null)
                {
                    AdicionarErroProcessamento("Mercado não encontrado no sistema.");
                    return CustomResponse();
                }

                await _mercadoRepository.Remover(mercado);

                return CustomResponse(mercado);
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }
    }
}
