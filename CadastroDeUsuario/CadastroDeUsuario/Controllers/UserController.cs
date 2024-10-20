using Microsoft.AspNetCore.Mvc;

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
