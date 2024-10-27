﻿using Microsoft.AspNetCore.Http.Connections;
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
    }   
}