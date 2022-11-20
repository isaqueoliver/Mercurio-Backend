using Back.Mercurio.Api.Models;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    public class CidadeController : MainController
    {
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IEstadoRepository _estadoRepository;

        public CidadeController(ICidadeRepository cidadeRepository, IEstadoRepository estadoRepository)
        {
            _cidadeRepository = cidadeRepository;
            _estadoRepository = estadoRepository;
        }

        /// <summary>
        /// Método para obter todos os Cidades
        /// </summary>
        [HttpGet("ObterPorId/{cidadeId}")]
        [ProducesResponseType(typeof(CidadeViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<CidadeViewModel>> ObterPorId(Guid cidadeId)
        {
            try
            {
                var cidade = await _cidadeRepository.ObterPorId(cidadeId);
                if (cidade is not null)
                {
                    return Ok(cidade.CidadeMapToCidadeViewModel());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        /// <summary>
        /// Método para obter todos os Cidades
        /// </summary>
        [HttpGet("ObterTodasPorEstado/{estadoId}")]
        [ProducesResponseType(typeof(IEnumerable<CidadeViewModel>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<CidadeViewModel>>> ObterTodasCidadesPorEstado(Guid estadoId)
        {
            try
            {
                var cidades = await _cidadeRepository.ObterTodasCidadesPorEstadoId(estadoId);
                if (cidades.Any())
                {
                    return Ok(cidades.CidadeMapToCidadeViewModel());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpPost("Adicionar-Cidades/{idEstado}")]
        public async Task<ActionResult> AdicionarCidadesPorEstado([FromBody, Required] List<string> cidades, Guid idEstado)
        {
            try
            {
                List<string> cidadeString = new List<string>();
                var estado = await _estadoRepository.ObterPorId(idEstado);
                if (estado is null)
                {
                    return CustomResponse("Estado não foi encontrado!");
                }

                foreach (var cidade in cidades)
                {
                    var nome = cidade.Split(":")[1];
                    var cidadeAdd = new Cidade(nome, estado.Id);
                    cidadeString.Add($"new Cidade(new Guid({cidadeAdd.Id}), {nome}, new Guid({estado.Id}))");
                }

                return CustomResponse(cidadeString);
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }
    }
}
