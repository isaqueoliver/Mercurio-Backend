using Back.Mercurio.Api.Usuario;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ProdutoValorMedioController : MainController
    {
        private readonly IAspNetUser _user;
        private readonly IProdutoValorMedioRepository _produtoValorMedioRepository;

        public ProdutoValorMedioController(IAspNetUser user,
               IProdutoValorMedioRepository produtoValorMedioRepository)
        {
            _user = user;
            _produtoValorMedioRepository = produtoValorMedioRepository;
        }

        [HttpGet("ObterTodosPorEstadoECidade/{estadoId}/{cidadeId}")]
        public async Task<ActionResult<IEnumerable<ProdutoValorMedio>>> ObterPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            try
            {
                var produtos = await _produtoValorMedioRepository.ObterTodosPorEstadoECidade(estadoId, cidadeId);
                if(produtos.Any())
                {
                    return CustomResponse(produtos);
                }

                return NoContent();
            }
            catch(Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpGet("ObterTodosPorMercado/{mercadoId}")]
        public async Task<ActionResult<IEnumerable<ProdutoValorMedio>>> ObterPorMercado(Guid mercadoId)
        {
            try
            {
                var produtos = await _produtoValorMedioRepository.ObterTodosPorMercado(mercadoId);
                if (produtos.Any())
                {
                    return CustomResponse(produtos);
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
