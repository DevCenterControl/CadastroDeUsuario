using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class FirstLetter
    {
        [Required(ErrorMessage = "First letter is mandatory")]
        public required char? first { get; set; }
    }
}
