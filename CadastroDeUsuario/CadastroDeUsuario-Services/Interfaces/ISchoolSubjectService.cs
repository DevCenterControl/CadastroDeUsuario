using CadastroDeUsuario_DTO.Request.Materia;
using CadastroDeUsuario_DTO.Response.Materia;
using CadastroDeUsuario_Infra.Repository.Interfaces;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface ISchoolSubjectService 
    {
        Task<SchoolSubjectResponseDTO> CreateSchoolSubject(SchoolSubjectRequestDTO request);
        Task<List<SchoolSubjectResponseDTO>> GetAllSchoolSubjects();
        Task DeleteAllSchoolSubjects();
    }
}
