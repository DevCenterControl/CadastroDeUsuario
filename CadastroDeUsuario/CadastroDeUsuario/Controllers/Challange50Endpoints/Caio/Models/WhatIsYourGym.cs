using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Controllers.Challange50Endpoints.Caio.Models
{
    public class WhatIsYourGym
    {
        [Required(ErrorMessage = "Name of the gym is required.")]
        public required string gym { get; set; }
    }
}
