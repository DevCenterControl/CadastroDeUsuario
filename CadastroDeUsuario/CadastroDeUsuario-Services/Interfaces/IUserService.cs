using Azure.Core;
using CadastroDeUsuario_DTO.Request.User;
using CadastroDeUsuario_DTO.Response.User;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface IUserService
    {
        Task <CreatUserResponseDto>CreateUser(CreateUserRequestDTO request);
        Task<GetUserResponseDTO> GetUsersByName( GetUserRequestDTO request);
        Task<DeleteUserResponseDTO> DeleteUser(DeleteUserRequestDTO request);
        Task<UpdateUserResponseDTO> UpdateUser(UpdateUserRequestDTO request);
        Task<List<GetUserResponseDTO>> GetAllUsersByName(GetUserRequestDTO request);



    }

}
