using CadastroDeUsuario_DTO.Request.User;
using CadastroDeUsuario_DTO.Response.User;
using CadastroDeUsuario_DTO.UserDTO;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface IUserService
    {
        Task <CreatUserResponseDto>CreateUser(CreateUserRequestDTO request);
        Task<List<UserDTO>> GetUsersByName(string name);
        Task<UserDTO> DeleteUser(string Cpf);
    }
}
