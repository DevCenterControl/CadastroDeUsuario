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
        string specialCharacters = "!@#$%&*(){}[];:.,<>?/-=+¢¬£~^`_¨|";

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string email = request.email;
            string password = request.password;      
        

            if (email.Contains("@@"))
            {
                return BadRequest("Email invalido");
            }

            var isPermitted = provedoresPermitidos.Any(provedor => email.EndsWith(provedor, StringComparison.OrdinalIgnoreCase));

            if (!isPermitted)
            {
                return BadRequest("Email com provedor invalido");
            }

            if (email.Contains("!") || email.Contains("#") || email.Contains("$") || email.Contains(".."))
            {
                return BadRequest("Caracteres Invalidos");
            }

            if (email.StartsWith("."))
            {
                return BadRequest("Email inválido, nao é possivel iniciar com ponto final. ");
            }
     
            if (password.Contains(email))
            {
                return BadRequest("O password nao pode ser igual ao email.");
            }

            if (!password.Any(char.IsUpper))
            {
                return BadRequest("Password deve conter pelo menos uma letra maiuscula.");
            }

            if (!password.Any(char.IsNumber))
            {
                return BadRequest("Passoword deve conter pelo menos um numero.");
            }

            if (!password.Any(ch => specialCharacters.Contains(ch)))
            {
                return BadRequest("Passowrd deve conter pelo menos um caractere especial.");
            }

            if (!password.Any(char.IsLower))
            {
                return BadRequest("Passowrd deve conter pelo menos uma letra minuscula.");
            }

            return Ok("Login efetuado com sucesso.");

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
