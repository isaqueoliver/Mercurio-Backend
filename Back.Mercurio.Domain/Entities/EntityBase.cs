namespace Back.Mercurio.Domain.Entities
{
    public abstract class EntityBase : Entity
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
