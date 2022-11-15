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
    [Authorize]
    [Route("api/[controller]")]
    public class ReporteController : MainController
    {
        private readonly IAspNetUser _user;
        private readonly IReporteRepository _reporteRepository;

        public ReporteController(IReporteRepository reporteRepository, IAspNetUser user)
        {
            _reporteRepository = reporteRepository;
            _user = user;
        }

        /// <summary>
        /// Método para obter todos os Reportes
        /// </summary>
        [HttpGet("ObterTodos")]
        [ProducesResponseType(typeof(IEnumerable<ReporteModelView>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<ReporteModelView>>> ObterTodos()
        {
            try
            {
                var reportes = await _reporteRepository.ObterTodosPorUsuarioId(_user.ObterUserId());
                if (reportes.Any())
                {
                    return Ok(reportes.ReporteMapToReporteModelView());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpPost("Adicionar")]
        [ProducesResponseType(typeof(Reporte), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> AdicionarReporte([FromBody, Required] ReporteViewModel reporte)
        {
            try
            {
                var reporteAdd = new Reporte(reporte.Descricao, reporte.AssuntoId, _user.ObterUserId());
                var result = await _reporteRepository.Adicionar(reporteAdd);

                if (result)
                {
                    return Created("Reporte adicionado com sucesso!", reporteAdd);
                }

                AdicionarErroProcessamento("Erro ao adicionar o reporte");
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpPatch("Responder")]
        [ProducesResponseType(typeof(Reporte), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> AdicionarResposta([FromBody, Required] RespostaViewModel resposta)
        {
            try
            {
                var reporte = await _reporteRepository.ObterPorId(resposta.ReporteId);
                if(reporte is null)
                {
                    AdicionarErroProcessamento("Reporte não foi encontrado!");
                    return CustomResponse();
                }
                reporte.AdicionarReposta(resposta.Resposta, _user.ObterUserId());
                var result = await _reporteRepository.Atualizar(reporte);

                if (result)
                {
                    return Ok("Reporte respondido!");
                }

                AdicionarErroProcessamento("Erro ao responder o reporte");
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }
    }
}
