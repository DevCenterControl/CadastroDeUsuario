using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario_DTO.Response.User
{
    public class CreatUserResponserDTO
    {
        public bool IsCreated { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
