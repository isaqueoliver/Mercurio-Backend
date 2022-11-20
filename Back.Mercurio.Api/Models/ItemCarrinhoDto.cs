namespace Back.Mercurio.Api.Models
{
    public struct ItemCarrinhoViewModel
    {
        public Guid ProdutoId { get; set; }
        public Guid CidadeId { get; set; }
        public int Quantidade { get; set; }

        public ItemCarrinhoViewModel(Guid cidadeId, Guid produtoId, int quantidade)
        {
            ProdutoId = produtoId;
            CidadeId = cidadeId;
            Quantidade = quantidade;
        }
    }
}
