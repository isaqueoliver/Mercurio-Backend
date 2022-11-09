using Back.Mercurio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
