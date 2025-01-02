using CadastroDeUsuario_Domain.Entities.Materia;
using CadastroDeUsuario_DTO.Request.Materia;
using CadastroDeUsuario_DTO.Response.Materia;
using CadastroDeUsuario_Infra.Repository;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using CadastroDeUsuario_Services.Interfaces;

namespace CadastroDeUsuario_Services.Materia
{
    public class SchoolSubjectService : ISchoolSubjectService
    {
        #region Fields
        private readonly IBaseRepository<SchoolSubjectDomain> _schoolSubjectRepository;
        #endregion

        #region Constructor
        public SchoolSubjectService(IBaseRepository<SchoolSubjectDomain> materiaRepository)
        {
            _schoolSubjectRepository = materiaRepository;
        }
        #endregion

        #region Methods
        public async Task<SchoolSubjectResponseDTO> CreateSchoolSubject(SchoolSubjectRequestDTO request)
        {
            var materia = new SchoolSubjectDomain
            {
                Nome = request.Nome
            };

            await _schoolSubjectRepository.Insert(materia);

            return new SchoolSubjectResponseDTO
            {
                Id = materia.Id,
                Nome = materia.Nome
            };
        }

        public async Task<List<SchoolSubjectResponseDTO>> GetAllSchoolSubjects()
        {
            var materias = await _schoolSubjectRepository.GetAllSchoolSubjects();
            return materias.Select(x => new SchoolSubjectResponseDTO
            {
                Id = x.Id,
                Nome = x.Nome
            }).ToList();
        }

        public async Task DeleteAllSchoolSubjects()
        {
            await _schoolSubjectRepository.DeleteAllSchoolSubjects();
        }
        #endregion
    }

}
