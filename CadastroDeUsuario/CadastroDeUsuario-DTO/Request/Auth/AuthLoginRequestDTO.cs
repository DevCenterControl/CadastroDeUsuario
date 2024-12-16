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

     
        public string email { get; set; }

        [Required(ErrorMessage = "Password é obrigatorio.")]
        [MinLength(8, ErrorMessage = "Password deve conter no minimo 8 caracteres.")]
        public string password { get; set; }

       
        public string CPF { get; set; }

        #endregion     
    }
}