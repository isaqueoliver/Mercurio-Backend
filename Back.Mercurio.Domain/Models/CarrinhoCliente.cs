using Back.Mercurio.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back.Mercurio.Domain.Models
{
    public class CarrinhoCliente : Entity
    {
        public Guid ClienteId { get; private set; }
        public decimal ValorTotal { get; private set; }
        public Guid MercadoId { get; private set; }

        public virtual Mercado Mercado { get; private set; }
        public virtual List<CarrinhoItem> Itens { get; private set; } = new List<CarrinhoItem>();

        public CarrinhoCliente(Guid clienteId)
        {
            ClienteId = clienteId;
        }

        public CarrinhoCliente() { }

        internal int ObterQuantidadeItens()
        {
            int quantidade = 0;

            foreach (var item in Itens)
                quantidade += item.Quantidade;

            return quantidade;
        }

        public void AdicionarMercado(Guid mercadoId)
        {
            MercadoId = mercadoId;
        }

        internal void CalcularValorCarrinho()
        {
            ValorTotal = Itens.Sum(x => x.CalcularValor());
        }

        public bool CarrinhoItemExistente(CarrinhoItem item)
        {
            return Itens.Any(x => x.ProdutoId == item.ProdutoId);
        }

        public CarrinhoItem ObterPorProdutoId(Guid produtoId)
        {
            return Itens.FirstOrDefault(x => x.ProdutoId == produtoId);
        }

        public void AdicionarItem(CarrinhoItem item)
        {
            item.AssociarCarrinho(Id);

            if (CarrinhoItemExistente(item))
            {
                var itemExistente = ObterPorProdutoId(item.ProdutoId);
                itemExistente.AdicionarUnidades(item.Quantidade);

                item = itemExistente;
                Itens.Remove(itemExistente);
            }
            Itens.Add(item);
            CalcularValorCarrinho();
        }

        internal void AtualizarItem(CarrinhoItem item)
        {
            item.AssociarCarrinho(Id);

            var itemExistente = ObterPorProdutoId(item.ProdutoId);

            Itens.Remove(itemExistente);
            Itens.Add(item);

            CalcularValorCarrinho();
        }

        internal void AtualizarUnidades(CarrinhoItem item, int unidades)
        {
            item.AtualizarUnidades(unidades);
            AtualizarItem(item);
        }

        public void RemoverItem(CarrinhoItem item)
        {
            Itens.Remove(ObterPorProdutoId(item.ProdutoId));

            CalcularValorCarrinho();
        }
    }

    public class CarrinhoItem : Entity
    {
        public CarrinhoItem()
        {
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Valor { get; private set; }
        public string Imagem { get; private set; }

        public Guid ProdutoId { get; private set; }
        public virtual Produto Produto { get; private set; }

        public Guid CarrinhoClienteId { get; private set; }        
        public virtual CarrinhoCliente CarrinhoCliente { get; private set; }

        public CarrinhoItem(Guid produtoId, string nome, int quantidade, decimal valor, string imagem)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
            Imagem = imagem;
        }

        internal void AssociarCarrinho(Guid carrinhoId)
        {
            CarrinhoClienteId = carrinhoId;
        }

        internal decimal CalcularValor()
        {
            return Quantidade * Valor;
        }

        internal void AdicionarUnidades(int unidades)
        {
            Quantidade += unidades;
        }

        internal void AtualizarUnidades(int unidades)
        {
            Quantidade = unidades;
        }
    }

}
