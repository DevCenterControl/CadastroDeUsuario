using Microsoft.AspNetCore.Mvc;
using CadastroDeUsuario.Models;
// Responsavel por fazer o login, lougout, esqueci a senha. 

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class AuthController : Controller
    {
        string[] provedoresPermitidos = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com" };

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                string email = request.email;
                string password = request.password;


            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Ok("Usuario autenticado com sucesso.");

        }

        [HttpPost("Logout")]
        public IActionResult Logout()
        {
            //Método utilizado para limpar todos os dados do usuario,
            //que ficam armazenados no servidor  para autenticação.
            //HttpContext.Session.Clear();

            //Metodo utilizado junto com o front - end para descartar o token de validação,
            //e fazer logout de cookies de autenticação.
            //HttpContext.SignOutAsync();

            // Método utilizado para remover um cookie de autenticação,
            // substituindo o "AuthCookie" pelo nome do Cookie especifico que deseja limpar.
            //Response.Cookies.Delete("AuthCookie");

            //Como nossa API ainda é bem simples e nao estamos trabalhando com tokens e armazenamento de dados
            // nosso endpoint simplesmente retorna uma mensagem basica de confirmação de logout.

            return Ok(new { message = "Sessão encerrada." });
        }
    }
}
