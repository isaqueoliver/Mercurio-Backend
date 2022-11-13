using Back.Mercurio.Api.Usuario;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ProdutoUsuarioController : MainController
    {
        private readonly IAspNetUser _user;
        private readonly IProdutoUsuarioRepository _produtoUsuarioRepository;

        public ProdutoUsuarioController(IAspNetUser user,
               IProdutoUsuarioRepository produtoUsuarioRepository)
        {
            _user = user;
            _produtoUsuarioRepository = produtoUsuarioRepository;
        }

        [HttpGet("ObterTodosPorEstadoECidade/{estadoId}/{cidadeId}")]
        public async Task<ActionResult<IEnumerable<ProdutoUsuario>>> ObterPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            try
            {
                var produtos = await _produtoUsuarioRepository.ObterTodosPorEstadoECidade(estadoId, cidadeId);
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

        [HttpGet("ObterTodosPorMercado/{mercadoId}")]
        public async Task<ActionResult<IEnumerable<ProdutoUsuario>>> ObterPorMercado(Guid mercadoId)
        {
            try
            {
                var produtos = await _produtoUsuarioRepository.ObterTodosPorMercado(mercadoId);
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

        [HttpGet("ObterTodosPorUsuario/{usuarioId}")]
        public async Task<ActionResult<IEnumerable<ProdutoUsuario>>> ObterPorUsuario(Guid usuarioId)
        {
            try
            {
                var produtos = await _produtoUsuarioRepository.ObterTodosPorUsuario(usuarioId);
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
