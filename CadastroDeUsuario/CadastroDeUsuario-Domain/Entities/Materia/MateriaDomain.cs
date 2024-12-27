﻿using CadastroDeUsuario_Domain.Entities.Nota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Domain.Entities.Materia
{
    public class MateriaDomain
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<NotaDomain> Notas { get; set; } = new List<NotaDomain>();
    }
}
