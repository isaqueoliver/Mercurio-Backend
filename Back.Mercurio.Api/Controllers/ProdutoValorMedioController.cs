using Back.Mercurio.Api.Models;
using Back.Mercurio.Api.Usuario;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Back.Mercurio.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<ActionResult<IEnumerable<ProdutoValorMedioModelView>>> ObterPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            try
            {
                var produtos = await _produtoValorMedioRepository.ObterTodosPorEstadoECidade(estadoId, cidadeId);
                if(produtos.Any())
                {
                    return CustomResponse(produtos.ProdutoValorMedioMapToProdutoValorMedioModelView());
                }

                return NoContent();
            }
            catch(Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpGet("ObterTodosPorMercado/{mercadoId}")]
        public async Task<ActionResult<IEnumerable<ProdutoValorMedioModelView>>> ObterPorMercado(Guid mercadoId)
        {
            try
            {
                var produtos = await _produtoValorMedioRepository.ObterTodosPorMercado(mercadoId);
                if (produtos.Any())
                {
                    return CustomResponse(produtos.ProdutoValorMedioMapToProdutoValorMedioModelView());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpGet("ObterTodosPorProdutoNome/{nome}")]
        public async Task<ActionResult<IEnumerable<ProdutoUsuarioModelView>>> ObterTodosPorProdutoNome([MaxLength(25)] string nome)
        {
            try
            {
                var produtos = await _produtoValorMedioRepository.ObterProdutosPorNome(nome);
                if (produtos.Any())
                {
                    return CustomResponse(produtos.ProdutoValorMedioMapToProdutoValorMedioModelView());
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
