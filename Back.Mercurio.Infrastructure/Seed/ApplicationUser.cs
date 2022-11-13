using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back.Mercurio.Infrastructure.Seed
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public Guid EstadoId { get; set; }
        [Required]
        public Guid CidadeId { get; set; }
    }
}
