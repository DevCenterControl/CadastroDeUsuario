using CadastroDeUsuario_Domain.Entities.Nota;
using CadastroDeUsuario_DTO.Request.Note;
using CadastroDeUsuario_DTO.Response.Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Services.Interfaces
{
    public interface INoteService
    {
        Task<CreateNoteResponseDTO> CreateNote(CreateNoteRequestDTO note);
        Task<List<GetNoteByUserIdResponseDTO>> GetNoteByUserId(int UserId);
        Task DeleteAllNotes();
       
        
    }
}
