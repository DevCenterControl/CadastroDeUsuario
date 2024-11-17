﻿using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario_DTO.Request.User
{
    internal class CreateUserRequestDTO
    {
        [Required(ErrorMessage = "É NECESSARIO INFORMAR A IDADE DO USUARIO NO MOMENTO DO CADASTRO.")]
        public int Idade { get; set; } /*ISSO É UMA PROPRIEDADE*/

        [Required]
        [MaxLength(10)]
        public string Nome { get; set; } /*ISSO É UMA PROPRIEDADE*/

        [Required]
        [MaxLength(11)]
        [MinLength(10)]
        public string Cpf { get; set; } /*ISSO É UMA PROPRIEDADE*/

        [MaxLength(120)]
        [MinLength(4)]
        public string Endereco { get; set; } /*ISSO É UMA PROPRIEDADE*/
    }
}
