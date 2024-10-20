using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
//CREAT, READ, UPDATE E DELETE.
namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        [HttpPost("CreatUser")]
        public string creatUser(string name, string telefone, string endereço, string cpf)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "O nome informado e invalido";
            }
            return "Usuario cadastrado";
        }


        // metodo = endpoint


        [HttpGet("GetAllUsers")]
        public List<string> GetAllUsers()
        {
            var allUser = new List<string>();
            var user1 = "Caio";
            var user2 = "Bode";
            var user3 = "Paulo";
            var user4 = "Akamaru";

            allUser.Add(user1);
            allUser.Add(user2);
            allUser.Add(user3);
            allUser.Add(user4);

            return allUser;
        }

        [HttpGet("GetUserByName")]
        public List<string> GetUserByName(string name)
        {
             return  new List<string>();
        }
    }
}
