using Back.Mercurio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Domain.Models
{
    public class Reporte : EntityBase
    {
        public string Descricao { get; private set; }
        public Status Status { get; private set; }
        public string Resposta { get;private set; }

        public Guid AssuntoId { get; private set; }
        public virtual Assunto Assunto { get; private set; }

        public Reporte() { }
        public Reporte(string descricao, Guid assuntoId, Guid usuarioCriacao)
        {
            Descricao = descricao;
            AssuntoId = assuntoId;
            UsuarioCriacao = usuarioCriacao;
        }
    }

    public enum Status
    {
        AguardandoResposta,
        Respondido
    }
}
