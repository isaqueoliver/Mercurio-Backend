using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class Mercado : EntityBase
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Imagem { get; private set; }
        public DateTime? DataAlteracao { get; private set; }
        public Guid? UsuarioAlteracao { get; private set; }

        public Guid EstadoId { get; private set; }
        public virtual Estado Estado { get; private set; }

        public Guid CidadeId { get; private set; }
        public virtual Cidade Cidade { get; private set; }

        public virtual List<ProdutoUsuario> ProdutosUsuarios { get; private set; }
        public virtual List<ProdutoValorMedio> ProdutosValoresMedios { get; private set; }

        public Mercado() { }
        public Mercado(string nome, Guid estadoId, Guid cidadeId, Guid usuarioId, string endereco, string imagem)
        {
            Nome = nome;
            Endereco = endereco;
            DataCriacao = DateTime.UtcNow;
            CidadeId = cidadeId;
            EstadoId = estadoId;
            UsuarioCriacao = usuarioId;
            Imagem = imagem;
        }
    }
}
