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
        private readonly IProdutoRepository _produtoRepository;

        public CarrinhoController(IAspNetUser user, ICarrinhoRepository carrinhoRepository, IProdutoRepository produtoRepository)
        {
            _user = user;
            _carrinhoRepository = carrinhoRepository;
            _produtoRepository = produtoRepository;
        }

        [HttpPost("Adicionar-Item")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> AdicionarItemCarrinho(ItemCarrinhoDto item)
        {
            try
            {
                var carrinho = await _carrinhoRepository.ObterCarrinhoCliente(_user.ObterUserId());
                var carrinhoItem = item.ParaCarrinhoItem();

                if (carrinho is null)
                {
                    carrinho = await ManipularNovoCarrinho(carrinhoItem);
                }
                else
                {
                    await ManipularCarrinhoExistente(carrinho, carrinhoItem);
                }

                //if (!OperacaoValida()) return CustomResponse();

                //await ProcessarCarrinhoCliente(carrinho, _user.ObterUserId());

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
                }
                else
                {
                    await _carrinhoRepository.Atualizar(carrinho);
                }

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
                //var carrinho = await ProcessarCarrinhoCliente(await _carrinhoRepository.ObterCarrinhoCliente(_user.ObterUserId()) ?? new CarrinhoCliente(), _user.ObterUserId());
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
            return new CarrinhoDto(carrinho.ValorTotal, carrinho.Mercado, carrinho.Itens);
        }

        private async Task<CarrinhoCliente> ManipularNovoCarrinho(CarrinhoItem item)
        {
            var carrinho = new CarrinhoCliente(_user.ObterUserId());
            var produto = await _produtoRepository.ObterPorId(item.ProdutoId);

            carrinho.AdicionarItem(item);
            if (produto is null)
            {
                AdicionarErroProcessamento($"Item: {item.Nome} não existente na lista de produtos.");
                return carrinho;
            }

            //carrinho.Mercado = produto.Mercado?.Nome;

            if (await _carrinhoRepository.Adicionar(carrinho) is false) AdicionarErroProcessamento($"Não foi possível adicionar {item.Nome} no carrinho.");

            return carrinho;
        }

        private async Task ManipularCarrinhoExistente(CarrinhoCliente carrinho, CarrinhoItem item)
        {
            var produtoItemExistente = carrinho.CarrinhoItemExistente(item);
            var produto = await _produtoRepository.ObterPorId(item.ProdutoId);

            carrinho.AdicionarItem(item);
            if (produto is null)
            {
                AdicionarErroProcessamento($"Item: {item.Nome} não existente na lista de produtos.");
                return;
            }
            //carrinho.Mercado = produto.Mercado?.Nome;

            if (produtoItemExistente)
            {
                if (await _carrinhoRepository.AtualizarItem(carrinho.ObterPorProdutoId(item.ProdutoId)) is false) AdicionarErroProcessamento($"Não foi possivel atualizar o {item.Nome} no carrinho.");
            }
            else
            {
                if (await _carrinhoRepository.AdicionarItem(item) is false) AdicionarErroProcessamento($"Não foi possível adicionar o {item.Nome} no carrinho.");
            }

            if (await _carrinhoRepository.Atualizar(carrinho) is false) AdicionarErroProcessamento($"Não foi possível atualizar o carrinho.");
        }

        private async Task<CarrinhoCliente> ProcessarCarrinhoCliente(CarrinhoCliente carrinho, Guid userId)
        {
            //_ = Task.Run(async () =>
            //{
            List<Produto> produtos = new();
            List<CarrinhoCliente> carrinhos = new();
            foreach (var item in carrinho.Itens)
            {
                produtos.AddRange(await _produtoRepository.ObterProdutosPorNome(item.Nome));
            }

            //foreach (var itens in produtos.GroupBy(x => x.Nome).Select(x => x.ToList()).ToList())
            //{
            //    foreach (var item in itens)
            //    {
            //        var itemCarrinho = new CarrinhoItem(item.Id, item.Nome, carrinho.Itens.First(x => x.Nome == item.Nome).Quantidade, item.Valor, item.Imagem);
            //        if (carrinhos.Any(x => x.Mercado == item.Mercado.Nome))
            //        {
            //            carrinhos.First(x => x.Mercado == item.Mercado.Nome).AdicionarItem(itemCarrinho);
            //        }
            //        else
            //        {
            //            CarrinhoCliente carrinhoCliente = new();
            //            carrinhoCliente.AdicionarItem(itemCarrinho);
            //            carrinhos.Add(carrinho);
            //        }
            //    }
            //}
            carrinhos = carrinhos.Where(x => x.Itens.Count == carrinho.Itens.Count).ToList();
            var carrinhoValido = carrinhos.First(x => x.ValorTotal == carrinhos.Min(x => x.ValorTotal));
            //carrinhoValido.AdicionarMercado(produtos.First(x => x.Id == carrinhoValido.Itens.First().ProdutoId).Mercado.Nome);

            await _carrinhoRepository.Atualizar(carrinhoValido);

            return carrinhoValido;

            //});
        }
    }
}
