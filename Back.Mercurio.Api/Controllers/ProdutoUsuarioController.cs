using Back.Mercurio.Api.Models;
using Back.Mercurio.Api.Usuario;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Back.Mercurio.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ProdutoUsuarioController : MainController
    {
        private readonly IProdutoUsuarioRepository _produtoUsuarioRepository;
        private readonly IProdutoValorMedioRepository _produtoValorMedioRepository;
        private readonly IMercadoRepository _mercadoRepository;
        private readonly IAspNetUser _user;

        public ProdutoUsuarioController(IProdutoUsuarioRepository produtoUsuarioRepository,
               IProdutoValorMedioRepository produtoValorMedioRepository,
               IMercadoRepository mercadoRepository,
               IAspNetUser user)
        {
            _produtoUsuarioRepository = produtoUsuarioRepository;
            _produtoValorMedioRepository = produtoValorMedioRepository;
            _mercadoRepository = mercadoRepository;
            _user = user;
        }

        [HttpPost("Adicionar")]
        public async Task<ActionResult<ProdutoUsuario>> Adicionar([FromBody] ProdutoUsuarioViewModel produto)
        {
            try
            {
                var mercado = await _mercadoRepository.ObterPorId(produto.MercadoId);
                if (mercado is null)
                {
                    AdicionarErroProcessamento("Mercado não foi encontrado!");
                    return CustomResponse();
                }

                var produtoAdd = new ProdutoUsuario(produto.ProdutoId, produto.MercadoId, mercado.EstadoId, mercado.CidadeId, _user.ObterUserId(), produto.Valor);
                var result = await _produtoUsuarioRepository.Adicionar(produtoAdd);
                if (result)
                {
                    await Task.Run(async () => await AdicionarProdutoValorMedio(mercado, produto.ProdutoId));

                    return Created("Produto adicionado com sucesso!", produtoAdd);
                }

                AdicionarErroProcessamento("Erro ao adicionar o Produto.");
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpGet("ObterTodosPorEstadoECidade/{estadoId}/{cidadeId}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProdutoUsuarioModelView>>> ObterPorEstadoECidade(Guid estadoId, Guid cidadeId)
        {
            try
            {
                var produtos = await _produtoUsuarioRepository.ObterTodosPorEstadoECidade(estadoId, cidadeId);
                if (produtos.Any())
                {
                    return CustomResponse(produtos.ProdutoUsuarioMapToProdutoUsuarioModelView());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpGet("ObterTodosPorMercado/{mercadoId}")]
        public async Task<ActionResult<IEnumerable<ProdutoUsuarioModelView>>> ObterPorMercado([Required] Guid mercadoId)
        {
            try
            {
                var produtos = await _produtoUsuarioRepository.ObterTodosPorMercado(mercadoId);
                if (produtos.Any())
                {
                    return CustomResponse(produtos.ProdutoUsuarioMapToProdutoUsuarioModelView());
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
                var produtos = await _produtoUsuarioRepository.ObterProdutosPorNome(nome);
                if (produtos.Any())
                {
                    return CustomResponse(produtos.ProdutoUsuarioMapToProdutoUsuarioModelView());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpGet("ObterTodosPorUsuario")]
        public async Task<ActionResult<IEnumerable<ProdutoUsuarioModelView>>> ObterPorUsuario()
        {
            try
            {
                var produtos = await _produtoUsuarioRepository.ObterTodosPorUsuario(_user.ObterUserId());
                if (produtos.Any())
                {
                    return CustomResponse(produtos.ProdutoUsuarioMapToProdutoUsuarioModelView());
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        private async Task AdicionarProdutoValorMedio(Mercado mercado, Guid produtoId)
        {
            var produtos = await _produtoUsuarioRepository.ObterTodosPorMercadoEProduto(mercado.Id, produtoId);

            int indexMediana = produtos.Count() / 2;

            decimal valorMediana = produtos.OrderBy(x => x.Valor).ElementAt(indexMediana).Valor;

            var produtoMedio = await _produtoValorMedioRepository.ObterPorMercadoEProduto(mercado.Id, produtoId);

            if (produtoMedio is not null)
            {
                produtoMedio.AtualizarValor(valorMediana);
                await _produtoValorMedioRepository.Atualizar(produtoMedio);
            }
            else
            {
                produtoMedio = new(produtoId, mercado.Id, mercado.EstadoId, mercado.CidadeId, valorMediana);
                await _produtoValorMedioRepository.Adicionar(produtoMedio);
            }
        }
    }
}
