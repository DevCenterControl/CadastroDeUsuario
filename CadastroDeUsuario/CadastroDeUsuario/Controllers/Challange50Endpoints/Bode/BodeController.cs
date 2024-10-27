using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
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
        public IActionResult FavoriteMark(string lacoste)
        {

            if (string.IsNullOrEmpty(lacoste))
            {
                return BadRequest("The lascote parameter cannot be null.");
            }
            else
            {
                return Ok(lacoste);
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

        [HttpGet("MyProfession")]
        public string MyProfession()
        {
            var name = "Fisioterapia";

            return name;
        }

        [HttpPost("MyName")]
        public bool MyName(string name)
        {
            if (name == "Lucas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost("BestPhysicalExercise")]
        public string BestPhysicalExercise(string favorite)
        {
            if (!string.IsNullOrEmpty(favorite))
            {
                return "My Favorite exercise and mandatory";
            }
            else
            {
                return favorite;
            }
        }

        [HttpPost("CarCost")]
        public double CarCost(double value)
        {
            if (value < 18000.0)

            {
                return value;
            }
            else
            {
                return 0;
            }

        }

        [HttpPost("SumXY")]
        public int SumXY(int x2, int y3)
        {
            var resultado = x2 + y3;

            return resultado;
        }

        [HttpGet("GetMyFavoritePerfume")]
        public string GetMyFavoritePerfume()
        {
            var name = "Pacco Rabanne";

            return name;
        }

        [HttpPost("MyFavoriteSeason")]
        public bool MyFavotiteSeason(string favorite)
        {
            if (favorite == "Frio")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet("GetTheBestFootballGame")]
        public string GetTheBestFootballGame()
        {
            var name = "Fifa";

            return name;
        }

        [HttpPost("HomeValue")]
        public int HomeValue(int value)
        {
            if (value == 20000.0)
            {
                return value;
            }
            else
            {
                return 0;

            }
        }

        [HttpGet("GetMySneakersList")]
        public List<string> GetMySneakersList()
        {
            var MySneakersList = new List<string>();

            var Sneakers1 = "Nike";
            var Sneakers2 = "Lacoste";
            var Sneakers3 = "Adidas";
            var Sneakers4 = "Osklen";

            MySneakersList.Add(Sneakers1);
            MySneakersList.Add(Sneakers2);
            MySneakersList.Add(Sneakers3);
            MySneakersList.Add(Sneakers4);

            return MySneakersList;
        }

        [HttpPost("MyGrossSalary")]
        public double MyGrossSalary(double amount)
        {
            if (amount <= 10500.0)
            {
                return amount;
            }
            else
            {
                return 0;
            }
        }

        [HttpPost("MyFavoriteAnimal")]
        public bool MyfavoriteAnimal(string name)
        {
            if (name == "Lion")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPost("MyPositionOnTheFootballField")]
        public string MyPositionOnTheFootballField(string favorite)
        {
            if (string.IsNullOrEmpty(favorite))
            {
                return "The favorite position on the field is a must";
            }
            else
            {
                return favorite;
            }
        }

        [HttpPost("SumAc")]
        public int SumAc(int a, int c)
        {
            return (a + c);
        }

        [HttpPost("TeamWithoutAWorldCup")]
        public IActionResult TeamWithoutAWorldCup(string team)
        {
            if (string.IsNullOrEmpty(team))
            {
                return BadRequest("Empty team");
            }
            else
            {
                return Ok(team);
            }
        }

        [HttpPost("BiggestStatechampion")]
        public bool BiggesStateChampion(string team)
        {
            if (team == "Corinthians")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        [HttpGet("GetCorinthiansTitlesList")]
        public List<string> GetCorinthiansTitlesList()
        {
            var CorinthiansTitlesList = new List<string>();

            var Titles1 = "6 Brasilian";
            var Titles2 = "1 worldwide";
            var Titles3 = "1 Libertadores";
            var Titles4 = "3 Copa do Brasil";

            CorinthiansTitlesList.Add(Titles1);
            CorinthiansTitlesList.Add(Titles2);
            CorinthiansTitlesList.Add(Titles3);
            CorinthiansTitlesList.Add(Titles4);

            return CorinthiansTitlesList;

        }

        [HttpPost("TheGreatestChampionOfTheChampionsLeague")]
        public bool TheGreatestChampionOfTheChampionsLeague(string team)
        {
            if (team == "Real Madrid")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet("GetMyBirthdayDate")]
        public string GetMyBirthdayDate()
        {
            var Date = "12 april";
            {
                return Date;
            }

        }

        [HttpGet("MybeerFavorite")]
        public string MybeerFavorite()
        {
            var name = "Heineken";
            {
                return name;
            }
        }

        [HttpPost("TheBestFootballPlayers")]
        public List<string> TheBestFootballPlayers()
        {
            var Players = new List<string>();

            var Players1 = "Ronaldinho Gaucho";
            var Players2 = "Ronaldo";
            var Players3 = "Zidane";
            var Players4 = "Cristiano Ronaldo";
            var Players5 = "Messi";
            var Players6 = "Neymar";

            Players.Add(Players1);
            Players.Add(Players2);
            Players.Add(Players3);
            Players.Add(Players4);
            Players.Add(Players5);
            Players.Add(Players6);
            {
                return Players;
            }

        }

        [HttpPost("WorsVideoGame")]
        public IActionResult WorsVideoGame(string game)
        {
            if (!string.IsNullOrEmpty(game))
            {
                return BadRequest("Racing Game");
            }
            else
            {
                return Ok(game);
            }
        }

        [HttpGet("GetMyNephewName")]
        public string GetMyNephewName()
        {
            var name = "Ravi";
            {
                return name;

            }
        }

        [HttpGet("GetFavoriteChief")]
        public string GetFavoriteChief()
        {
            var name = "Paulo Medeiros";
            {
                return name;
            }
        }

        [HttpGet("GetMyFamilyMembersQuantity")]
        public string GetMyFamilyMembersQuantity()
        {
            var quantity = "5 members";
            {
                return quantity;
            }
        }

        [HttpPost("WorstMovieGenre")]
        public IActionResult WorstMovieGenre(string genre)
        {
            if (!string.IsNullOrEmpty(genre))
            {
                return BadRequest("Terror");
            }
            else
            {
                return Ok(genre);
            }


        }

        [HttpGet("GetMyFavoriteTeamsFromThFloodplain")]
        public List<string> GetMyFavoriteTeamsFromThFloodplain()
        {
            var teams = new List<string>();

            var teams1 = "Arsenalcool";
            var teams2 = "Revelação";
            var teams3 = "Comercial";
            var teams4 = "Vida loka";

            teams.Add(teams1);
            teams.Add(teams2);
            teams.Add(teams3);
            teams.Add(teams4);

            {
                return teams;
            }

        }

        [HttpGet("GetMyWatchesList")]
        public List<string> GetMyWatchesList()
        {
            var Watches = new List<string>();

            var Watches1 = "Lacoste blue";
            var Watches2 = "Lacoste Black";
            var Watches3 = "Lacoste red";
            var Watches4 = "Quiksiver grey";

            Watches.Add(Watches1);
            Watches.Add(Watches2);
            Watches.Add(Watches3);
            Watches.Add(Watches4);

            {
                return Watches; 
            }

         
        }

        [HttpPost("WorstTeamInTheWorld")]
        public bool WorstTeamInTheWorld(string team)
        {
            if (team == "Ibis FC") 
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [HttpGet("GetMyTeamsBiggestRivals")]
        public List<string> GetMyTeamsBiggestRivals()
        {
            var rivals = new List<string>();

            var rivals1 = "Porcada";
            var rivals2 = "Bambis";
            var rivals3 = "Peixada";
            var rivals4 = "Urubu";

            rivals.Add(rivals1);
            rivals.Add(rivals2);
            rivals.Add(rivals3);
            rivals.Add(rivals4);

            {
                return rivals;
            }
        }

        [HttpGet("GetMyFavoriteSnack")]
        public string GetMyFavoriteSnack()
        {
            var name = "McDonad's";
            {
                return name;
            }

        }

        [HttpPost("MonthlyAccounts")]
        public IActionResult MonthlyAccounts(double value) 
        {
            if (value != 2800.0)
            {
                return BadRequest("Incorrect value");
            }
            else
            {
                return Ok($"My bills for the month and : {value}");
            } 
            

        }
        [HttpGet("GetMyFirstJob")]
        public string GetMyFirstJob()
        {
            var name = "Lava rapido";
            {
                return name;
            }
        }
        [HttpPost("MyFirstLove")]
        public bool MyFirstLove(string name)
        {
            if (name == "Luciana")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}