using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Domain.Entities
{
    public class EntityBase : Entity
    {
        public DateTime DataCriacao { get; set; }
        public Guid UsuarioCriacao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public Guid? UsuarioExclusao { get; set; }

        protected EntityBase()
        {
            DataCriacao = DateTime.UtcNow;
        }
    }
}
