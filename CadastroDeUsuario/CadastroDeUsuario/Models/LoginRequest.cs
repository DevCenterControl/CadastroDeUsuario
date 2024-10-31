using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CadastroDeUsuario.Models
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        [MaxLength(50, ErrorMessage = "Limite de caracteres atingido, seu limite é de 50 caracteres.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password é obrigatorio.")]
        [MinLength(8, ErrorMessage = "Password deve conter no minimo 8 caracteres.")]
        public string password { get; set; }
    }
}
