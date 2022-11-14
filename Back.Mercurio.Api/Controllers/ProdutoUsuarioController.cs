using Back.Mercurio.Api.Models;
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
        private readonly IProdutoValorMedioRepository _produtoValorMedioRepository;
        private readonly IMercadoRepository _mercadoRepository;

        public ProdutoUsuarioController(IAspNetUser user,
               IProdutoUsuarioRepository produtoUsuarioRepository,
               IProdutoValorMedioRepository produtoValorMedioRepository,
               IMercadoRepository mercadoRepository)
        {
            _user = user;
            _produtoUsuarioRepository = produtoUsuarioRepository;
            _produtoValorMedioRepository = produtoValorMedioRepository;
            _mercadoRepository = mercadoRepository;
        }

        [HttpPost("Adicionar")]
        public async Task<ActionResult<ProdutoUsuario>> Adicionar([FromBody]ProdutoUsuarioViewModel produto)
        {
            try
            {
                var mercado = await _mercadoRepository.ObterPorId(produto.MercadoId);
                if(mercado is null)
                {
                    AdicionarErroProcessamento("Mercado não foi encontrado!");
                    return CustomResponse();
                }

                var produtoAdd = new ProdutoUsuario(produto.ProdutoId, produto.MercadoId, mercado.EstadoId, mercado.CidadeId, produto.Valor);
                var result = await _produtoUsuarioRepository.Adicionar(produtoAdd);
                if(result)
                {
                    await Task.Run(async () => await AdicionarProdutoValorMedio(mercado, produto.ProdutoId));

                    return Created("Produto adicionado com sucesso!", produtoAdd);
                }

                AdicionarErroProcessamento("Erro ao adicionar o Produto.");
                return CustomResponse();
            }
            catch(Exception ex)
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
        public async Task<ActionResult<IEnumerable<ProdutoUsuarioModelView>>> ObterPorMercado(Guid mercadoId)
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
        public async Task<ActionResult<IEnumerable<ProdutoUsuarioModelView>>> ObterPorUsuario(Guid usuarioId)
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

        private async Task AdicionarProdutoValorMedio(Mercado mercado, Guid produtoId)
        {
            var produtos = await _produtoUsuarioRepository.ObterTodosPorMercadoEProduto(mercado.Id, produtoId);

            decimal valorMedio = produtos.Sum(x => x.Valor) / produtos.Count();

            var produtoMedio = await _produtoValorMedioRepository.ObterPorMercadoEProduto(mercado.Id, produtoId);

            if(produtoMedio is not null)
            {
                produtoMedio.AtualizarValor(valorMedio);
                await _produtoValorMedioRepository.Atualizar(produtoMedio);
            }
            else
            {
                produtoMedio = new(produtoId, mercado.Id, mercado.EstadoId, mercado.CidadeId, valorMedio);
                await _produtoValorMedioRepository.Adicionar(produtoMedio);
            }
        }
    }
}
