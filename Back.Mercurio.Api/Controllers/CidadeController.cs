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
        [HttpGet("ObterTodos")]
        [ProducesResponseType(typeof(IEnumerable<Cidade>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<Cidade>>> ObterTodos()
        {
            try
            {
                var cidades = await _cidadeRepository.ObterTodos();
                if (cidades is not null && cidades.Any())
                {
                    return Ok(cidades);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpPost("Adicionar")]
        [ProducesResponseType(typeof(Cidade), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> AdicionarCidade([FromBody, Required] CidadeViewModel cidade)
        {
            try
            {
                var estado = await _estadoRepository.ObterPorId(cidade.IdEstado);
                if(estado is null)
                {
                    return CustomResponse("Estado não foi encontrado!");
                }

                var cidadeAdd = new Cidade(cidade.Nome, estado);
                var result = await _cidadeRepository.Adicionar(cidadeAdd);

                if (result)
                {
                    return Created("Cidade adicionado com sucesso!", cidadeAdd);
                }

                AdicionarErroProcessamento("Erro ao adicionar o cidade");
                return CustomResponse();
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
                var estado = await _estadoRepository.ObterPorId(idEstado);
                if (estado is null)
                {
                    return CustomResponse("Estado não foi encontrado!");
                }

                foreach (var cidade in cidades)
                {
                    var nome = cidade.Split(":")[1];
                    var cidadeAdd = new Cidade(nome, estado);
                    var result = await _cidadeRepository.Adicionar(cidadeAdd);

                    if(result is false) AdicionarErroProcessamento("Erro ao adicionar o cidade");
                }

                return CustomResponse();
            }
            catch(Exception ex)
            {
                return CustomResponse(ex);
            }
        }
    }
}
