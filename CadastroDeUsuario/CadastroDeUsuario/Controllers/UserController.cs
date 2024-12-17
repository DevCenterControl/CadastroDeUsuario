using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_DTO.Request.User;
using CadastroDeUsuario_Services.Auth;
using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace CadastroDeUsuario
{
    //[Authorize]
    [ApiController]
    [Route("Controller")]
    public class UserController : Controller
    {
        #region Fields

        private readonly IUserService _userService;
        #endregion

        #region Constructor
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region EndPoints
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestDTO request)
        {
            try
            {
                var result = await _userService.CreateUser(request);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}

