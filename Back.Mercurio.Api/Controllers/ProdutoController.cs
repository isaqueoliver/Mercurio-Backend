using Back.Mercurio.Api.Models;
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
    public class ProdutoController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        /// <summary>
        /// Método para obter todos os produtos
        /// </summary>
        [HttpGet("ObterTodos")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> ObterTodos()
        {
            try
            {
                var result = ParaProdutoViewModel(await _produtoRepository.ObterTodos());
                if (result is not null && result.Any())
                {
                    return Ok(result);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        /// <summary>
        /// Método para adicionar um novo produto, ele precisa estar atrelado há um mercado já existente
        /// </summary>
        /// <param name="produto">Produto a ser adicionado</param>
        [HttpPost("Adicionar")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<Produto>> Adicionar([FromBody, Required] ProdutoViewModel produto)
        {
            try
            {
                var produtoAdd = new Produto(produto.Nome, produto.Imagem);
                var result = await _produtoRepository.Adicionar(produtoAdd);

                if (result)
                {
                    return Created("Produto criado com sucesso!", produtoAdd);
                }

                AdicionarErroProcessamento($"Ocorreu uma falha ao adicionar o Produto {produto.Nome}.");
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpDelete("Remover/{produtoId}")]
        [ProducesResponseType(typeof(Produto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> Remover(Guid produtoId)
        {
            try
            {
                var produto = await _produtoRepository.ObterPorId(produtoId);

                if (produto is null)
                {
                    AdicionarErroProcessamento("Não foi possível encontrar o produto no sistema.");
                    return CustomResponse();
                }

                await _produtoRepository.Remover(produto);

                return CustomResponse(produto);
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        private static List<ProdutoViewModel> ParaProdutoViewModel(IEnumerable<Produto> produtos)
        {
            List<ProdutoViewModel> produtoViewModels = new List<ProdutoViewModel>(produtos.Count());
            foreach (var produto in produtos)
            {
                produtoViewModels.Add(new ProdutoViewModel(produto.Id, produto.Nome, produto.Imagem));
            }
            return produtoViewModels;
        }
    }
}
