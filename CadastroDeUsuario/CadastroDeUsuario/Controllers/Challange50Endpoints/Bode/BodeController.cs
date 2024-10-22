using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Controllers.Challange.Bode
{
    [ApiController]
    [Route("Controller")]
    public class BodeController : Controller
    {
        [HttpGet("GetUser")]
        public string GetUser()
        {
            var user = "Desenvolvedor 1";
            return user;
        }

        [HttpGet("GetProjectName")]
        public string GetProjectName()
        {
            var name = "CenterControl";
            return name;
        }
        


        


    }
}
