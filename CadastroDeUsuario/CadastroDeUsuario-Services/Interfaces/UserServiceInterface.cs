using CadastroDeUsuario_DTO.Request.User;
using CadastroDeUsuario_DTO.Response.User;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface UserServiceInterface
    {
        CreatUserResponserDTO CreateUser(CreateUserRequestDTO user);
    }
}
