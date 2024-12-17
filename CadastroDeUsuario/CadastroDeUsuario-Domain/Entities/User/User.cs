using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario_Domain.Entities.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } 
     
        public string Cpf { get; set; } 

        public string Endereco { get; set; } 
    }
}
