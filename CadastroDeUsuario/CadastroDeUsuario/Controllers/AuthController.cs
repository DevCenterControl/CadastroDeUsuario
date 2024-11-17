using CadastroDeUsuario_DTO.Request.Auth;
using Microsoft.AspNetCore.Mvc;
namespace CadastroDeUsuario
{
    [ApiController]
    [Route("Controller")]
    public class AuthController : Controller
    {
        [HttpPost("Login")]
        public IActionResult Login([FromBody] AuthLoginRequestDTO request)
        {
            try
            {
                return Ok("Usuário autenticado com sucesso.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("Logout")]
        public IActionResult Logout()
        {   
            return Ok(new { message = "Sessão encerrada." });
        }    
    }
}
