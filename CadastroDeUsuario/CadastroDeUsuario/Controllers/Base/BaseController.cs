using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
