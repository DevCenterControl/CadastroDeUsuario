using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
