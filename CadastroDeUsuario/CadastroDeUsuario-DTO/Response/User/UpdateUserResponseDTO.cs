﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Response.User
{
    public class UpdateUserResponseDTO
    {
        public bool IsUpdated { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
