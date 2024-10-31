using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class UserController : Controller
    {
        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] UserModel user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(user);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Create user (meio caminho andado).
        //Get user by name.
        //update user.
        //getalluser.
        //delete all user.
        //delete by name.
    }
}

