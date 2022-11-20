using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class ProdutoValorMedio : Entity
    {
        public Guid ProdutoId { get; private set; }
        public virtual Produto Produto { get; private set; }

        public Guid MercadoId { get; private set; }
        public virtual Mercado Mercado { get; private set; }

        public Guid EstadoId { get; private set; }
        public virtual Estado Estado { get; private set; }

        public Guid CidadeId { get; private set; }
        public virtual Cidade Cidade { get; private set; }

        public decimal Valor { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        public ProdutoValorMedio() { }
        public ProdutoValorMedio(Guid produtoId, Guid mercadoId, Guid estadoId, Guid cidadeId, decimal valor)
        {
            ProdutoId = produtoId;
            MercadoId = mercadoId;
            EstadoId = estadoId;
            CidadeId = cidadeId;
            Valor = valor;
            Ativo = true;
        }

        public void AtualizarValor(decimal valor)
        {
            Valor = valor;
        }
    }
}
