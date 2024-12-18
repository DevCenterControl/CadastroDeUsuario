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

        [HttpGet("GetUsersByName")]
        public async Task<IActionResult> GetUsersByName([FromQuery] string name)
        {
            try
            {
                var users = await _userService.GetUsersByName(name);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteUser/{Cpf}")]
        public async Task<IActionResult> DeleteUser(string Cpf)
        {
            try
            {
                var deletedUser = await _userService.DeleteUser(Cpf);
                if (deletedUser == null)
                    return NotFound("Usuário não encontrado.");

                return Ok($"Usuário com o CPF {deletedUser.Cpf} foi deletado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        #endregion
    }
}

