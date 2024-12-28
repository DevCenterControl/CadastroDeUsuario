using CadastroDeUsuario_DTO.Request.Materia;
using CadastroDeUsuario_DTO.Response.Materia;
using CadastroDeUsuario_Infra.Repository.Interfaces;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface IMateriaService 
    {
        Task<MateriaResponseDTO> CreateMateria(MateriaRequestDTO request);
        Task<List<MateriaResponseDTO>> GetAllMaterias();
    }
}
