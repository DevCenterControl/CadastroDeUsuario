using Microsoft.AspNetCore.Mvc;
using CadastroDeUsuario.Models;
using CadastroDeUsuario.Helper.FakeDataBase;

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class AuthController : Controller
    {
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
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

        #region privateMethods
        private List<FakeDataBaseUser> GetUsers()
        {
            var usuariosNoBancoDeDados = new List<FakeDataBaseUser>();
            var usuario1 = new FakeDataBaseUser { email = "caio@hotmail.com", password = "Caio12345!" };
            usuariosNoBancoDeDados.Add(usuario1);

            return usuariosNoBancoDeDados;
        }
        #endregion
    }
}
