using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Request.User
{
    public class UpdateUserRequestDTO
    {
#nullable enable
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }  
#nullable disable
        public DateTime UpdatedDate { get; set; }
    }
}
