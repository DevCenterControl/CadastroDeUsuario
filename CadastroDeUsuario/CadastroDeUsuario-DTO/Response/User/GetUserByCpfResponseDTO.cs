﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Response.User
{
    public class GetUserByCpfResponseDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
    }
}
