using System.ComponentModel.DataAnnotations;
namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class YourFavoriteMovie
    {
        [Required(ErrorMessage = "Movie name is required.")]
        [StringLength(20, ErrorMessage = "Movie name must contain a maximum of 20 characters")]
        public required string Title { get; set; }
    }
}
