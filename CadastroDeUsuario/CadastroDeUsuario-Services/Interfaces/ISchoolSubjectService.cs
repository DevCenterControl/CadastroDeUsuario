using CadastroDeUsuario_DTO.Request.Materia;
using CadastroDeUsuario_DTO.Response.Materia;
using CadastroDeUsuario_Infra.Repository.Interfaces;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface ISchoolSubjectService 
    {
        Task<MateriaResponseDTO> CreateSchoolSubject(MateriaRequestDTO request);
        Task<List<MateriaResponseDTO>> GetAllMaterias();
    }
}
