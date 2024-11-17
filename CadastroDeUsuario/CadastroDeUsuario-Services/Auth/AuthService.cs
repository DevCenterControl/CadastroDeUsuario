using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_DTO.Response.Auth;
using CadastroDeUsuario_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Services.Auth
{
    public class AuthService : IAuthService
    {
        public AuthLoginResponseDTO Authenticate(AuthLoginRequestDTO request)
        {
            ValidateRequestDTO(request);
            throw new NotImplementedException();
        }

        private void ValidateRequestDTO(AuthLoginRequestDTO request)
        {

            string[] provedoresPermitidos = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com" };


            var isPermitted = provedoresPermitidos.Any(provedor => request.email.EndsWith(provedor, StringComparison.OrdinalIgnoreCase));

            if (!isPermitted)
            {
                throw new Exception ("O email deve ter um provedor permitido: @gmail.com, @outlook.com, @hotmail.com ou @yahoo.com.");
            }

        }
    }
}

