using Back.Mercurio.Domain.Entities;
namespace Back.Mercurio.Domain.Models
{
    public class ProdutoUsuario : EntityBase
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

        public ProdutoUsuario() { }
        public ProdutoUsuario(Guid produtoId, Guid mercadoId, Guid estadoId, Guid cidadeId, Guid usuarioId, decimal valor)
        {
            ProdutoId = produtoId;
            MercadoId = mercadoId;
            EstadoId = estadoId;
            CidadeId = cidadeId;
            UsuarioCriacao = usuarioId;
            Valor = valor;
        }
    }
}
