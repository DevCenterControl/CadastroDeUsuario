using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Request.User
{
    public class UpdateUserRequestDTO
    {
        [Required]
        public string Cpf { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
    }
}
