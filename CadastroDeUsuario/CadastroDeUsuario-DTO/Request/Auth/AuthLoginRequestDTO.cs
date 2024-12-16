using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Request.Auth
{
    public class AuthLoginRequestDTO
    {
        #region Properties

        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        [MaxLength(50, ErrorMessage = "Limite de caracteres atingido, seu limite é de 50 caracteres.")]
        [MinLength(10, ErrorMessage = "Email deve conter no minimo 10 caracteres.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password é obrigatorio.")]
        [MinLength(8, ErrorMessage = "Password deve conter no minimo 8 caracteres.")]
        public string password { get; set; }

        #endregion     
    }
}