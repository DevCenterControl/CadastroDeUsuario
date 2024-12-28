using CadastroDeUsuario_Domain.Entities.Materia;
using CadastroDeUsuario_DTO.Request.Materia;
using CadastroDeUsuario_DTO.Response.Materia;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using CadastroDeUsuario_Services.Interfaces;

namespace CadastroDeUsuario_Services.Materia
{
    public class MateriaService : IMateriaService
    {
        #region Fields
        private readonly IBaseRepository<MateriaDomain> _materiaRepository;
        #endregion

        #region Constructor
        public MateriaService(IBaseRepository<MateriaDomain> materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }
        #endregion

        #region Methods
        public async Task<MateriaResponseDTO> CreateMateria(MateriaRequestDTO request)
        {
            var materia = new MateriaDomain
            {
                Nome = request.Nome
            };

            await _materiaRepository.Insert(materia);

            return new MateriaResponseDTO
            {
                Id = materia.Id,
                Nome = materia.Nome
            };
        }

        public async Task<List<MateriaResponseDTO>> GetAllMaterias()
        {
            var materias = await _materiaRepository.GetAllMaterias();
            return materias.Select(x => new MateriaResponseDTO
            {
                Id = x.Id,
                Nome = x.Nome
            }).ToList();
        }
        #endregion
    }

}
