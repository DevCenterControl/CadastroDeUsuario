using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class HowOldAreYou
    {
        [Required(ErrorMessage = "Your age is required.")]
        [Range(1, 100, ErrorMessage = "Your age must be between 1 and 100 years old.")]
        public required int Age { get; set; }
    }
}
