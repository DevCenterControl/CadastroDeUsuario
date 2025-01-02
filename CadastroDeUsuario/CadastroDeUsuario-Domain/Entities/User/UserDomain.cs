using CadastroDeUsuario_Domain.Entities.Base;
using CadastroDeUsuario_Domain.Entities.Nota;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario_Domain.Entities.User
{
    public class UserDomain : BaseDomain
    {
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        [Required]
        public string Cpf { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<NoteDomain> Notas { get; set; } = new List<NoteDomain>();
      

    }
}
