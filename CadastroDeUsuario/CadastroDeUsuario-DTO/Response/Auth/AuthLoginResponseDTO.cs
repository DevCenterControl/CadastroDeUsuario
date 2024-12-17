using System.Net;

namespace CadastroDeUsuario_DTO.Response.Auth
{
    public class AuthLoginResponseDTO
    {
        public HttpStatusCode Code { get; set; }
        public bool IsSuccess { get; set; }
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Photo { get; set; }
        public string Token { get; set; }
    }
}
