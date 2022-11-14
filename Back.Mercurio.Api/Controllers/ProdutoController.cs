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
                var result = await _produtoRepository.ObterTodos();
                if (result.Any())
                {
                    return Ok(result.ProdutoMapToProdutoViewModel());
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
    }
}
