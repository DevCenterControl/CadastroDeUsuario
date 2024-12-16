﻿using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_DTO.Response.Auth;
using CadastroDeUsuario_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Services.Auth
{
    public class AuthService : IAuthService
    {
        public AuthLoginResponseDTO Authenticate(AuthLoginRequestDTO request)
        {
            //Validções
            ValidateProviderRequestDTO(request.email);
            ValidatePasswordRequestDTO(request.password);
            //Verificar no banco 
            return new AuthLoginResponseDTO();
        }

        #region private methods
        private void ValidateProviderRequestDTO(string email)
        {
            string[] provedoresPermitidos = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com" };

            var isPermitted = provedoresPermitidos.Any(provedor => email.EndsWith(provedor, StringComparison.OrdinalIgnoreCase));

            if (!isPermitted)
            {
                throw new Exception("O email deve ter um provedor permitido: @gmail.com, @outlook.com, @hotmail.com ou @yahoo.com.");
            }
        }

        private void ValidatePasswordRequestDTO(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("A senha é obrigatória.");
            }

            if (password.Contains(" "))
            {
                throw new Exception("A senha nao pode conter um espaço em branco.");
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                throw new Exception("A senha deve conter uma letra maiuscula.");
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                throw new Exception("A senha deve conter uma letra minuscula.");
            }

            if(!Regex.IsMatch(password, @"[0-9]"))
            {
                throw new Exception("A senha deve conter um numero.");
            }

            if(!Regex.IsMatch(password, @"[\W_]"))
            {
                throw new Exception("A senha deve conter um caracter especial.");
            }

        }

        #endregion

    }
}

