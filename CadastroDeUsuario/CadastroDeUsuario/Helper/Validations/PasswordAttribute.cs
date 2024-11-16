using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CadastroDeUsuario.Helper.Validations
{
    public class PasswordAttribute : ValidationAttribute
    {
        public int MinimumLength { get; set; } = 8;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;

            if (string.IsNullOrEmpty(password))
            {
                return new ValidationResult("A senha é obrigatória.");
            }
            
            if(password.Contains(" "))
            {
                return new ValidationResult("A senha nao pode conter um espaço em branco.");
            }

            if (password.Length < MinimumLength)
            {
                return new ValidationResult($"A senha deve ter pelo menos {MinimumLength} caracteres.");
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                return new ValidationResult("A senha deve conter pelo menos uma letra maiúscula.");
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                return new ValidationResult("A senha deve conter pelo menos uma letra minúscula.");
            }

            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                return new ValidationResult("A senha deve conter pelo menos um número.");
            }

            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                return new ValidationResult("A senha deve conter pelo menos um caractere especial.");
            }

            return ValidationResult.Success;
        }
    }
}
