using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CadastroDeUsuario.Controllers.Challange.Caio
{
    [ApiController]
    [Route("Controller")]
    public class CaioController : Controller
    {
        [HttpGet("GetName")]
        public string GetName()
        {
            var name = "Caio";
            return name;
        }

        [HttpGet("GetAge")]
        public int GetAge()
        {
            var age = 29;
            return age;
        }
    }
}
