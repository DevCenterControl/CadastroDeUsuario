using CadastroDeUsuario_Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario_Domain.Entities.User
{
    public class UserDomain : BaseDomain
    {
#nullable disable
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
