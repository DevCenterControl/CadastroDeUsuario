using CadastroDeUsuario_Domain.Entities.Nota;
using CadastroDeUsuario_DTO.Request.Note;
using CadastroDeUsuario_DTO.Response.Note;
using CadastroDeUsuario_Infra.Repository;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using CadastroDeUsuario_Services.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<CreateNoteResponseDTO> CreateNote(CreateNoteRequestDTO request)
        {
            if (request.Valor < 0 || request.Valor > 10)
            {
                throw new Exception("A nota deve ser de 0 a 10");
            }

            var note = new NoteDomain
            {
                UserId = request.UserId,
                MateriaId = request.MateriaId,
                Valor = request.Valor
            };

            await _noteRepository.Insert(note);

            return new CreateNoteResponseDTO
            {
                Id = note.UserId,
                UserId = note.UserId,
                MateriaId = note.MateriaId,
                Valor = note.Valor,
            };
        }

        public async Task<List<GetNoteByUserIdResponseDTO>> GetNoteByUserId(int UserId)
        {
            if (UserId <= 0)
            {
                throw new Exception("Id de usuario invalido");
            }

            var notes = await _noteRepository.FindAllWithIncludes(
                x => x.UserId == UserId,
                x => x.User,
                x => x.Materia
            );

            if (notes == null || !notes.Any())
            {
                throw new Exception("Nenhuma nota encontrada para este usuário");
            }

            return notes.Select(x => new GetNoteByUserIdResponseDTO
            {
                Id = x.Id,
                UserId = x.UserId,
                MateriaId = x.MateriaId,
                Materia = x.Materia.Nome,
                Usuario = x.User.Nome,
                Valor = x.Valor
            }).ToList();
        }

        public async Task DeleteAllNotes()
        {
            await _noteRepository.DeleteAllNotes();
        }

        #endregion

    }

}
