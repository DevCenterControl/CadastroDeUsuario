using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_DTO.Response.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthLoginResponseDTO> Authenticate(AuthLoginRequestDTO request);

    }
}
