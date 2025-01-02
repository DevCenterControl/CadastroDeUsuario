using CadastroDeUsuario_Domain.Entities.Base;
using CadastroDeUsuario_Domain.Entities.Nota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Domain.Entities.Materia
{
    public class SchoolSubjectDomain : BaseDomain
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<NoteDomain> Notas { get; set; } = new List<NoteDomain>();
    }
}
