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
            throw new NotImplementedException();
        }
    }
}
