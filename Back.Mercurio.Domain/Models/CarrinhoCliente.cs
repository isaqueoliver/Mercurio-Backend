using System.Text.Json.Serialization;

namespace Back.Mercurio.Domain.Models
{
    public class CarrinhoCliente
    {
        public Guid Id { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal ValorTotal { get; private set; }
        public string? Mercado { get; private set; }
        public List<CarrinhoItem> Itens { get; private set; } = new List<CarrinhoItem>();

        public CarrinhoCliente(Guid clienteId)
        {
            Id = Guid.NewGuid();
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

        public void AdicionarMercado(string mercado)
        {
            Mercado = mercado;
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

    public class CarrinhoItem
    {
        public CarrinhoItem()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public Guid ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Valor { get; private set; }
        public string Imagem { get; private set; }

        public Guid CarrinhoId { get; private set; }
        [JsonIgnore]
        public CarrinhoCliente CarrinhoCliente { get; private set; }

        public CarrinhoItem(Guid produtoId, string nome, int quantidade, decimal valor, string imagem)
        {
            Id = Guid.NewGuid();
            ProdutoId = produtoId;
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
            Imagem = imagem;
        }

        internal void AssociarCarrinho(Guid carrinhoId)
        {
            CarrinhoId = carrinhoId;
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
