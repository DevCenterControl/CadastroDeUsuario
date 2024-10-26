using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class YourFavoriteSinger
    {
        [Required(ErrorMessage = "Singer name is required.")]
        [StringLength(30, ErrorMessage = "Singer name must contain a maximum of 30 characters")]
        public required string Singer { get; set; }
    }
}
