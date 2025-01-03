using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Response.Note
{
    public class CreateNoteResponseDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MateriaId { get; set; }
        public double Valor { get; set; }
   
    }
}
