using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class Produto : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string? Categoria { get; set; }
        public string? Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Imagem { get; set; }

        public Guid IdMercado { get => Mercado.Id; }
        public Mercado Mercado { get; set; }

        public Produto() { }

        public Produto(string nome, decimal valor, Mercado mercado, string? imagem)
        {
            Nome = nome;
            Valor = valor;
            Mercado = mercado;
            Imagem = imagem;
            Ativo = true;
            DataCadastro = DateTime.Now;
        }
    }
}
