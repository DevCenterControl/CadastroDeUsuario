using Microsoft.AspNetCore.Mvc;
// Responsavel por fazer o login, lougout, esqueci a senha. 

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    public class AuthController : Controller
    {
        string[] provedoresPermitidos = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com" };

        [HttpPost("Login")]
        public string Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                return "Email não pode estar em branco";
            }

            if (email.Length <= 10)
            {
                return "Email inválido.";
            }

            if (!email.Contains("@"))
            {
                return "Email invalido";
            }

            if (email.Contains("@@"))
            {
                return "Email invalido";
            }

            var isPermitted = provedoresPermitidos.Any(provedor => email.EndsWith(provedor, StringComparison.OrdinalIgnoreCase));

            if (isPermitted == false)
            {
                return "Email com provedor invalido";
            }

            if (email.Contains("!"))
            {
                return "Caracteres Invalidos";
            }

            if (email.Contains("#"))
            {
                return "Caracteres Invalidos";
            }

            if (email.Contains("$"))
            {
                return "Caracteres Inválidos.";
            }

            if (email.Length >= 50)
            {
                return "Limite de caracteres atingido, seu limite é de 50 caracteres.";
            }

            if (email.Contains(".."))
            {
                return "Email invalido, não é possivel utilizar dois pontos finais consecutivos (..).";
            }

            if (email.StartsWith("."))
            {
                return "Email inválido, nao é possivel iniciar com ponto final. ";
            }

            if (string.IsNullOrEmpty(password))
            {
                return "Password não pode estar em branco";
            }

            return "Autenticado com sucesso.";

        }
    }
}
