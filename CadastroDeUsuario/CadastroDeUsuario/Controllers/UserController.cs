using Microsoft.AspNetCore.Mvc;
//CREAT, READ, UPDATE E DELETE.
namespace CadastroDeUsuario.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        
    }
}
