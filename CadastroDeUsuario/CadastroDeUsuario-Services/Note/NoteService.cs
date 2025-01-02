using CadastroDeUsuario_Domain.Entities.Nota;
using CadastroDeUsuario_DTO.Request.Note;
using CadastroDeUsuario_DTO.Response.Note;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using CadastroDeUsuario_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Services.Nota
{
    public class NoteService : INoteService
    {
        #region Fields
        private readonly IBaseRepository<NoteDomain> _noteRepository;
        #endregion

        #region Constructor
        public NoteService(IBaseRepository<NoteDomain> notaRepository)
        {
            _noteRepository = notaRepository;
        }
        #endregion

        #region Methods

        public async Task<NoteResponseDTO> CreateNote (NoteRequestDTO request)
        {
            var note = new NoteDomain
            {
                UserId = request.UserId,
                MateriaId = request.MateriaId,
                Valor = request.Valor
            };

            await _noteRepository.Insert(note);

            return new NoteResponseDTO
            {
                Id = note.Id,
                UserId = note.UserId,
                MateriaId = note.MateriaId,
                Valor = note.Valor
            };
        }

        #endregion

    }

}
