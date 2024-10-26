using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class TheMostFamousPodcast
    {
        [Required(ErrorMessage = "PodCast name is required.")]
        [StringLength(15, ErrorMessage = "PodCast name must contain a maximum of 15 characters")]
        public required string PodCast { get; set; }
    }
}
