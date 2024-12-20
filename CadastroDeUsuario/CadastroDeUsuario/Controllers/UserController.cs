using CadastroDeUsuario_Domain.Entities.User;
using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_DTO.Request.User;
using CadastroDeUsuario_Infra.Repository;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using CadastroDeUsuario_Services.Auth;
using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("GetUserByCpf")]
        public async Task<IActionResult> GetUserByCpf([FromQuery] GetUserByCpfRequestDTO request)
        {
            try
            {
                var users = await _userService.GetUserByCpf(request);

                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser(DeleteUserRequestDTO Cpf)
        {
            try
            {
                var deletedUser = await _userService.DeleteUser(Cpf);

                return Ok(deletedUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequestDTO request)
        {
            try
            {
                var result = await _userService.UpdateUser(request);

                if (result == null)
                    return NotFound("Usuário não encontrado.");

                return Ok($"Usuário com o CPF {request.Cpf} foi atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _userService.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllUsersByName")]
        public async Task<IActionResult> GetAllUsersByName([FromQuery] GetUserRequestDTO request)
        {
            try
            {
                var userList = await _userService.GetAllUsersByName(request);

                if (userList == null || !userList.Any())
                    return NotFound("Nenhum usuário encontrado com o nome especificado.");

                return Ok(userList);
            }
            catch (Exception ex)
            {

                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpDelete("DeleteUserById")]
        public async Task<IActionResult> DeleteUserById(DeleteUserByIdRequestDTO request)
        {
            try
            {
                var deletedUser = await _userService.DeleteUserById(request);

                return Ok(deletedUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteAllUsers")]
        public async Task<IActionResult> DeleteAllUsers()
        {
            try
            {
                await _userService.DeleteAllUsers();
                return Ok("Todos os usuarios foram deletados.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        #endregion
    }
}

