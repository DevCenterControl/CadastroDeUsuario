using Azure.Core;
using CadastroDeUsuario_DTO.Request.User;
using CadastroDeUsuario_DTO.Response.User;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface IUserService
    {
        Task <CreatUserResponseDto>CreateUser(CreateUserRequestDTO request);
        Task<GetUserByCpfResponseDTO> GetUserByCpf( GetUserByCpfRequestDTO request);
        Task<DeleteUserResponseDTO> DeleteUser(DeleteUserRequestDTO request);
        Task<UpdateUserResponseDTO> UpdateUser(UpdateUserRequestDTO request);
        Task<List<GetUserResponseDTO>> GetAllUsers();
        Task<List<GetUserResponseDTO>> GetAllUsersByName(GetUserRequestDTO request);
        Task<DeleteUserByIdResponseDTO> DeleteUserById(DeleteUserByIdRequestDTO request);

    }

}
