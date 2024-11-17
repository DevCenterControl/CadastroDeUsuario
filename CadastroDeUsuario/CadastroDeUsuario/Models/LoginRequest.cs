﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using CadastroDeUsuariousing CadastroDeUsuario-API.Helper.Validations;
-API.Helper.Validations;
using CadastroDeUsuariousing CadastroDeUsuario-API.Helper.Validations;
-API.Helper.Validations;

namespace CadastroDeUsuario
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        [MaxLength(50, ErrorMessage = "Limite de caracteres atingido, seu limite é de 50 caracteres.")]
        [MinLength(10, ErrorMessage = "Email deve conter no minimo 10 caracteres.")]
        [AllowedProviders]
        public string email { get; set; }

        [Required(ErrorMessage = "Password é obrigatorio.")]
        [PasswordAttribute]
        public string password { get; set; }
    }
}
