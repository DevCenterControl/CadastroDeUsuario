using CadastroDeUsuario_Domain.Entities.Materia;
using CadastroDeUsuario_Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Domain.Entities.Nota
{
    public class NotaDomain
    {
        public int Id { get; set; }

        
        public int UserId { get; set; }
        public UserDomain User { get; set; }

      
        public int MateriaId { get; set; }
        public MateriaDomain Materia { get; set; }

        
        public double Valor { get; set; }
    }
}
