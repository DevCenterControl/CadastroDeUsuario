﻿using CadastroDeUsuario_DTO.Request.Note;
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
        Task<NoteResponseDTO> CreateNote(NoteRequestDTO note);
    }
}
