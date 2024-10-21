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
        [HttpGet("GetName")]
        public string GetName()
        {
            var name = "Caio";
            return name;
        }

        [HttpGet("GetAge")]
        public int GetAge()
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
    }
}
