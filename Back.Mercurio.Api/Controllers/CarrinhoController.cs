using Back.Mercurio.Api.Models;
using Back.Mercurio.Api.Usuario;
using Back.Mercurio.Domain.Models;
using Back.Mercurio.Infrastructure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Back.Mercurio.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CarrinhoController : MainController
    {
        private readonly IAspNetUser _user;
        private readonly ICarrinhoRepository _carrinhoRepository;
        private readonly IProdutoValorMedioRepository _produtoValorMedioRepository;

        public CarrinhoController(IAspNetUser user,
            ICarrinhoRepository carrinhoRepository,
            IProdutoValorMedioRepository produtoValorMedioRepository)
        {
            _user = user;
            _carrinhoRepository = carrinhoRepository;
            _produtoValorMedioRepository = produtoValorMedioRepository;
        }

        [HttpPost("Adicionar-Item")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> AdicionarItemCarrinho(ItemCarrinhoViewModel itemCarrinho)
        {
            try
            {
                var produto = await _produtoValorMedioRepository.ObterProdutoMaisBartoPorEstadoECidade(itemCarrinho.CidadeId, itemCarrinho.ProdutoId);
                if (produto is null)
                {
                    AdicionarErroProcessamento("Produto não foi encontrado!");
                    return CustomResponse();
                }

                var carrinho = await _carrinhoRepository.ObterCarrinhoCliente(_user.ObterUserId());

                var carrinhoItem = new CarrinhoItem(produto.ProdutoId, produto.Produto.Nome, itemCarrinho.Quantidade, produto.Valor, produto.Produto?.Imagem);

                if (carrinho is null)
                {
                    carrinho = await ManipularNovoCarrinho(carrinhoItem, produto.Mercado.Id);
                    return CustomResponse();
                }

                carrinho.AdicionarItem(carrinhoItem);
                await ManipularCarrinhoExistente(carrinho, itemCarrinho);

                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpDelete("Remover-Item/{produtoId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> RemoverItemCarrinho(Guid produtoId)
        {
            try
            {
                var carrinho = await _carrinhoRepository.ObterCarrinhoCliente(_user.ObterUserId());
                var carrinhoItem = await ObterItemCarrinhoValidado(produtoId, carrinho);

                if (carrinhoItem is null) return CustomResponse();

                carrinho.RemoverItem(carrinhoItem);
                await _carrinhoRepository.RemoverItemCarrinho(carrinhoItem);

                if (carrinho.Itens.Any() is false)
                {
                    await _carrinhoRepository.RemoverCarrinho(carrinho);
                    return CustomResponse();
                }

                await _carrinhoRepository.Atualizar(carrinho);
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpDelete("Remover-Carrinho")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> RemoverCarrinho()
        {
            try
            {
                var carrinho = await _carrinhoRepository.ObterCarrinhoCliente(_user.ObterUserId());

                if (carrinho is null)
                {
                    AdicionarErroProcessamento("Carrinho Inválido.");
                    return CustomResponse();
                }

                await _carrinhoRepository.RemoverCarrinho(carrinho);
                return CustomResponse();
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        [HttpGet("Obter")]
        [ProducesResponseType(typeof(CarrinhoDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<CarrinhoDto>> Obter()
        {
            try
            {
                return CarrinhoClienteParaCarrinhoDto(await _carrinhoRepository.ObterCarrinhoCliente(_user.ObterUserId()) ?? new CarrinhoCliente());
            }
            catch (Exception ex)
            {
                return CustomResponse(ex);
            }
        }

        private async Task<CarrinhoItem> ObterItemCarrinhoValidado(Guid produtoId, CarrinhoCliente carrinho, CarrinhoItem item = null)
        {
            if (item is not null && produtoId != item.ProdutoId)
            {
                AdicionarErroProcessamento("O Item não corresponde ao informado.");
                return null;
            }

            if (carrinho is null)
            {
                AdicionarErroProcessamento("Carrinho não encontrado.");
                return null;
            }

            var itemCarrinho = await _carrinhoRepository.ObterCarrinhoItem(carrinho.Id, produtoId);

            if (itemCarrinho is null || !carrinho.CarrinhoItemExistente(itemCarrinho))
            {
                AdicionarErroProcessamento("O Item não está no carrinho.");
                return null;
            }

            return itemCarrinho;
        }

        private CarrinhoDto CarrinhoClienteParaCarrinhoDto(CarrinhoCliente carrinho)
        {
            return new CarrinhoDto(carrinho.ValorTotal, carrinho.Mercado?.Nome, carrinho.Itens);
        }

        private async Task<CarrinhoCliente> ManipularNovoCarrinho(CarrinhoItem item, Guid mercadoId)
        {
            var carrinho = new CarrinhoCliente(_user.ObterUserId());


            carrinho.AdicionarItem(item);

            carrinho.AdicionarMercado(mercadoId);

            if (await _carrinhoRepository.Adicionar(carrinho) is false) AdicionarErroProcessamento($"Não foi possível adicionar {item.Nome} no carrinho.");

            return carrinho;
        }

        private async Task ManipularCarrinhoExistente(CarrinhoCliente carrinho, ItemCarrinhoViewModel carrinhoItem)
        {
            var mercados = await _produtoValorMedioRepository.ObterTodosMercadosPorCidade(carrinhoItem.CidadeId);

            List<CarrinhoCliente> carrinhos = new List<CarrinhoCliente>(mercados.Count());

            foreach (var mercado in mercados)
            {
                var novoCarrinho = new CarrinhoCliente(_user.ObterUserId());
                foreach (var itemCarrinho in carrinho.Itens)
                {
                    var produto = await _produtoValorMedioRepository.ObterPorMercadoEProduto(mercado, carrinhoItem.ProdutoId);
                    if (produto is null)
                    {
                        novoCarrinho.AdicionarItem(itemCarrinho);
                        continue;
                    }
                    novoCarrinho.AdicionarItem(new CarrinhoItem(produto.Id, produto.Produto.Nome, itemCarrinho.Quantidade, produto.Valor, produto.Produto?.Imagem));
                    if (novoCarrinho.Mercado is null) novoCarrinho.AdicionarMercado(produto.Mercado.Id);
                }
                carrinhos.Add(novoCarrinho);
            }

            var carrinhoMaisBarato = carrinhos.OrderBy(x => x.ValorTotal).First();

            if (await _carrinhoRepository.Atualizar(carrinho) is false) AdicionarErroProcessamento($"Ocorreu um erro na hora de atualizar o carrinho.");

            //if (await _carrinhoRepository.Adicionar(carrinhoMaisBarato) is false) AdicionarErroProcessamento($"Não foi possível atualizar o carrinho.");
        }
    }
}
