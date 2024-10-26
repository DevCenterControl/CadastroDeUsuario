using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class InstrumentThatYouPlay
    {
        [Required(ErrorMessage = "Instrument name is required.")]
        public required string Instrument { get; set; }
    }
}
