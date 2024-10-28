using Microsoft.AspNetCore.Mvc;
// Responsavel por fazer o login, lougout, esqueci a senha. 

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    public class AuthController : Controller
    {
        string[] provedoresPermitidos = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com" };
        string specialCharacters = "!@#$%&*(){}[];:.,<>?/-=+¢¬£~^`_¨|";

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


            if (password.Length <= 8)
            {
                return "Password deve conter no minimo 8 caracteres.";
            }

            if (password.Contains(email))
            {
                return "O password nao pode ser igual ao email.";
            }

            if (!password.Any(char.IsUpper))
            {
                return "Password deve conter pelo menos uma letra maiuscula.";
            }

            if (!password.Any(char.IsNumber))
            {
                return "Passoword deve conter pelo menos um numero.";
            }

            if(!password.Any(ch => specialCharacters.Contains(ch)))
            {
                return "Passowrd deve conter pelo menos um caractere especial.";
            }

            return "Autenticado com sucesso.";

        }
    }
}
