using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Domain.Models
{
    public class Assunto : Entity
    {
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }

        public virtual List<Reporte> Reportes { get; private set; }

        public Assunto() { }
        public Assunto(string descricao, bool ativo)
        {
            Descricao = descricao;
            Ativo = ativo;
        }
        public Assunto(Guid id, string descricao, bool ativo)
        {
            Id = id;
            Descricao = descricao;
            Ativo = ativo;
        }
    }
}
