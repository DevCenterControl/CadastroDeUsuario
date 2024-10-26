using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class HowManyVideoGamesDoYouHave
    {
        [Required(ErrorMessage = "The quantity of the video games is required.")]
        public required int games { get; set; }
    }
}
