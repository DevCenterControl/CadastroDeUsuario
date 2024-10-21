using Microsoft.AspNetCore.Mvc;
// Responsavel por fazer o login, lougout, esqueci a senha. 

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    public class AuthController : Controller
    {
        [HttpPost("Login")]
        public bool Login(string user, string password)
        {
            if (user == "Paulo" && password == "123")
            {
                return true;
            }
            return false;   
        }
    }
}
