using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace CadastroDeUsuario
{
    [ApiController]
    [Route("Controller")]
    public class AuthController : Controller
    {
        #region Fields
        private readonly IAuthService _authService;

        #endregion

        #region Constructor

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        #endregion

        #region EndPoints

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] AuthLoginRequestDTO request)
        {
            try
            {
                var result = await _authService.Authenticate(request);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost("Logout")]
        public IActionResult Logout()
        {
            return Ok(new { message = "Sessão encerrada." });
        }
        #endregion
    }
}
