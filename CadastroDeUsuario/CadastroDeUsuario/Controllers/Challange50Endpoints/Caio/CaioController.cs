using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace CadastroDeUsuario.Controllers.Challange.Caio
{
    [ApiController]
    [Route("Controller")]
    public class CaioController : Controller
    {
        [HttpGet("GetDevName")]
        public string GetDevName()
        {
            var name = "Caio";
            return name;
        }

        [HttpGet("GetDevAge")]
        public int GetDevAge()
        {
            var age = 29;
            return age;
        }

        [HttpPost("AddAddress")]
        public string AddAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                return "Addrees is mandatory";
            }
            else
            {
                return "Address successfully added";
            }
        }

        [HttpPost("Email")]
        public bool Email(string email)
        {
            if (email == "caiorodrigo_dev@outlook.com")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [HttpGet("GetFirstUser")]
        public string GetFirstUser()
        {
            var firstUser = "Paulo Medeiros";
            return firstUser;
        }

        [HttpGet("GetAllStudentsList")]
        public List<string> GetAllStudentsList()
        {
            var AllStudentsList = new List<string>();
            var student1 = "Caio";
            var student2 = "Bode";
            var student3 = "Primo97";

            AllStudentsList.Add(student1);
            AllStudentsList.Add(student2);
            AllStudentsList.Add(student3);

            return AllStudentsList;
        }

        [HttpPost("FavoriteFood")]
        public bool FavoriteFood(string food)
        {
            if (food == "Churrasco")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [HttpPost("AddNewAccount")]
        public string AddNewAccount(string user, string password)
        {
            if (user == "DevMochilinha" && password == "2MochilinhaDev!@*")
            {
                return "New Account Successfuly added";
            }
            else
            {
                return "Invalid account";
            }
        }

        [HttpPost("Ps5SalePrice")]
        public IActionResult Ps5SalePrice(double value)
        {
            
            if (value < 3500.0)
            {
                return BadRequest("Wrong price");
            }
            else
            {
                return Ok("Correct price");
            }

        }
    }
}