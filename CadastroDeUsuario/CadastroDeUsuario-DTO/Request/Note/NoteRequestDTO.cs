using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Request.Note
{
    public class NoteRequestDTO
    {
        public int UserId { get; set; }
        public int MateriaId { get; set; }
        public double Valor { get; set; }
    }
}
