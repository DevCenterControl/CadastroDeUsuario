using CadastroDeUsuario.Controllers;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CadastroDeUsuario.Helper.Validations
{
   public class AllowedProvidersAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] provedoresPermitidos = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com" };

            if (value is string email)
            {
                var isPermitted = provedoresPermitidos.Any(provedor => email.EndsWith(provedor, StringComparison.OrdinalIgnoreCase));

                if (!isPermitted)
                {
                    return new ValidationResult("O email deve ter um provedor permitido: @gmail.com, @outlook.com, @hotmail.com ou @yahoo.com.");
                }
            }

            return ValidationResult.Success;
        }
    }
}

