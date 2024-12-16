using System.Net;

namespace CadastroDeUsuario_DTO.Response.Auth
{
    public class AuthLoginResponseDTO
    {
        public HttpStatusCode Code { get; set; }
        public bool IsSuccess { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
}
