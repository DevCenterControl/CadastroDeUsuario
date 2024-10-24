using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace CadastroDeUsuario.Controllers.Challange.Bode
{
    [ApiController]
    [Route("Controller")]
    public class BodeController : Controller
    {
        [HttpGet("GetUser")]
        public string GetUser()
        {
            var user = "Desenvolvedor 1";
            return user;
        }

        [HttpGet("GetProjectName")]
        public string GetProjectName()
        {
            var name = "CenterControl";
            return name;
        }

        [HttpGet("GetAllMembersFamilyList")]
        public List<string> GetAllMembersFamilyList()
        {
            var AllMembersFamilyList = new List<string>();

            var Family1 = "Antonio";
            var Family2 = "Gloria";
            var Family3 = "Luisa";

            AllMembersFamilyList.Add(Family1);
            AllMembersFamilyList.Add(Family2);
            AllMembersFamilyList.Add(Family3);

            return AllMembersFamilyList;
        }

        [HttpGet("GetTeamFavorite")]
        public string GetTeamFavorite()
        {
            var name = "Corinthians";
            return name;
        }
        [HttpPost("FavoriteGirl")]
        public bool FavoriteGirl(string girl)
        {
            if (girl == "morena")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpPost("YourFavoriteMark")]
        public IActionResult FavoriteMark(string lascote)
        {

            if (string.IsNullOrEmpty(lascote))
            {
                return BadRequest("The lascote parameter cannot be null.");
            }
            else
            {
                return Ok(lascote);
            }
        }
        [HttpGet("GetBestCartoonsList")]
        public List<string> GetBestCartoonsList()
        {
            var BestCartoonsList = new List<string>();

            var cartoons1 = "Dragon Ball Z";

            var cartoons2 = "Yu-Gi-Oh";

            var cartoons3 = "Cavaleiros do Zodiaco";

            var cartoons4 = "Bod Esponja";

            BestCartoonsList.Add(cartoons1);
            BestCartoonsList.Add(cartoons2);
            BestCartoonsList.Add(cartoons3);
            BestCartoonsList.Add(cartoons4);

            return BestCartoonsList;
        }
        [HttpGet("GetMonthlyBallad")]
        public string GetMonthlyBallad()
        {
            var amountMonthlyBallads = 4;

            return $"{amountMonthlyBallads} Monthly ballads";
        }
        [HttpGet("GetAnnualBallads")]
        public int GetAnnualBallads()
        {
            var amountAnnualBallads = 48;

            return amountAnnualBallads;
        }

        [HttpPost("YourFavoriteMusic")]
        public bool YourFavoriteMusic(string music)
        {
            if (music == "Funk")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpPost("BestFootballChampionship")]
        public string BestFootballChampionship(string favorite)
        {
            if (string.IsNullOrEmpty(favorite))
            {
                return "Your Favorite and mandatory championship";
            }
            else
            {
                return favorite;
            }
        }
    }
}
