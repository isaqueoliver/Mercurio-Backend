using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Mercurio.Domain.Entities
{
    public class EntityBase : Entity
    {
        public DateTime DataCricao { get; set; }
        public Guid UsuarioCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public Guid? UsuarioAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public Guid? UsuarioExclusao { get; set; }

        protected EntityBase()
        {
            DataCricao = DateTime.UtcNow;
        }
    }
}
