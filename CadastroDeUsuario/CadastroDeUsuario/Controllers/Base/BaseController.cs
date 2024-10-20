using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Controllers.Base
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
