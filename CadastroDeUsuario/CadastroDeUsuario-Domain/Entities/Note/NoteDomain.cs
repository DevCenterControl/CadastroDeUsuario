using CadastroDeUsuario_Domain.Entities.Base;
using CadastroDeUsuario_Domain.Entities.Materia;
using CadastroDeUsuario_Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Domain.Entities.Nota
{
    public class NoteDomain : BaseDomain
    {
        public int Id { get; set; }

        
        public int UserId { get; set; }
        public UserDomain User { get; set; }

      
        public int MateriaId { get; set; }
        public SchoolSubjectDomain Materia { get; set; }

        
        public double Valor { get; set; }
    }
}
