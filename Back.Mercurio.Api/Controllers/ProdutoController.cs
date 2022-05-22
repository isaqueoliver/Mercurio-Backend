using Back.Mercurio.Api.Models;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMercadoRepository _mercadoRepository;
        public ProdutoController(IProdutoRepository produtoRepository, IMercadoRepository mercadoRepository)
        {
            _produtoRepository = produtoRepository;
            _mercadoRepository = mercadoRepository;
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
                var mercado = await _mercadoRepository.ObterPorNome(produto.Nome);

                if (mercado is null)
                {
                    AdicionarErroProcessamento("Mercado não existente na base de dados.");
                    return CustomResponse();
                }

                var produtoAdd = new Produto(produto.Nome, produto.Valor, mercado, produto.Imagem);
                _produtoRepository.Adicionar(produtoAdd);

                return Created("Produto criado com sucesso!", produtoAdd);
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
                produtoViewModels.Add(new ProdutoViewModel(produto.Nome, produto.Mercado.Nome, produto.Valor, produto.Imagem));
            }
            return produtoViewModels;
        }
    }
}
