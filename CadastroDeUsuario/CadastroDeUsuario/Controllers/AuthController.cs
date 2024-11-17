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
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var usuariosNoBancoDeDados = GetUsers();
                var usuarioExiste = usuariosNoBancoDeDados.Any(x => x.email == request.email && x.password == request.password);

                if (!usuarioExiste)
                {
                    return BadRequest("Usuario nao encontrado");
                }

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
