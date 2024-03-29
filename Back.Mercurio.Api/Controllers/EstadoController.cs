﻿using Back.Mercurio.Api.Models;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("ObterPorId/{estadoId}")]
        [ProducesResponseType(typeof(EstadoViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<EstadoViewModel>> ObterPorId(Guid estadoId)
        {
            try
            {
                var estado = await _estadoRepository.ObterPorId(estadoId);
                if (estado is not null)
                {
                    return Ok(estado.EstadoMapToEstadoViewModel());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
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

        /// <summary>
        /// Método para obter todas as Cidades de um determinado Estado
        /// </summary>
        [HttpGet("ObterCidadesPorEstado/{estadoId}")]
        [ProducesResponseType(typeof(Estado), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<Estado>> ObterCidadesPorEstado(Guid estadoId)
        {
            try
            {
                var estado = await _estadoRepository.ObterPorId(estadoId);
                if (estado is not null)
                {
                    return Ok(estado);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpPost("ObterCidadesPorEstado/{estadoId}")]
        [ProducesResponseType(typeof(Estado), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> ProcessarCidades([FromBody] Dictionary<string, string> cidades, Guid estadoId)
        {
            try
            {
                var estado = await _estadoRepository.ObterPorId(estadoId);
                List<string> cidadeS = new();
                if (estado is not null)
                {
                    foreach (var cidade in cidades)
                        cidadeS.Add($"new Cidade({Guid.NewGuid()}, {cidade.Value}, {estadoId})");
                    return Ok(cidadeS);
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
