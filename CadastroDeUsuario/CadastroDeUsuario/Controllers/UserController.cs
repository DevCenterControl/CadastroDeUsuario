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

        [HttpGet("GetUserByName")]
        public List<string> GetUserByName(string name)
        {
            try
            {

                //essa é a nossa lista fake que esta simulando o banco de dados. (tipo uma lista telefonica das antigas)
                var listaDeUsuario = new List<string>();
                var usuario1 = "Paulo";
                var usuario2 = "Lucas";
                var usuario3 = "Caio";
                var usuario4 = "Greg";
                var usuario5 = "Jimmy";

                listaDeUsuario.Add(usuario1);
                listaDeUsuario.Add(usuario2);
                listaDeUsuario.Add(usuario3);
                listaDeUsuario.Add(usuario4);
                listaDeUsuario.Add(usuario5);

                var usuarioEncontrado = listaDeUsuario.Where(x => x.Contains(name)).ToList();

                return usuarioEncontrado;

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

