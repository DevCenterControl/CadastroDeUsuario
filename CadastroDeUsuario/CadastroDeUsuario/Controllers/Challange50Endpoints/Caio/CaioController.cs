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

        [HttpGet("GetMyDogsName")]
        public string GetMyDogsName()
        {
            var dogsName = "Mel";
            return dogsName;
        }

        public class NotebookRequirements
        {
            public required string Component { get; set; }
            public required string Quantity { get; set; }
        }

        [HttpGet("GetNotebookRequirements")]
        public List<NotebookRequirements> GetNotebookRequirements()
        {
            var NotebookRequirement = new List<NotebookRequirements>();
            var item1 = "Ram memory";
            var item2 = "SSD";
            var item3 = "HDMI Input";
            var item4 = "HDMI Output";
            var item5 = "USB input";

            var Value1 = "32Gb";
            var Value2 = "512Gb";
            var Value3 = "3";
            var Value4 = "2";
            var Value5 = "3";

            NotebookRequirement.Add(new NotebookRequirements { Component = item1, Quantity = Value1 });
            NotebookRequirement.Add(new NotebookRequirements { Component = item2, Quantity = Value2 });
            NotebookRequirement.Add(new NotebookRequirements { Component = item3, Quantity = Value3 });
            NotebookRequirement.Add(new NotebookRequirements { Component = item4, Quantity = Value4 });
            NotebookRequirement.Add(new NotebookRequirements { Component = item5, Quantity = Value5 });

            return NotebookRequirement;
        }

        public class YourFavoriteMovie
        {
            [Required(ErrorMessage = "Movie name is required.")]
            [StringLength(20, ErrorMessage = "Movie name must contain a maximum of 20 characters")]
            public required string Title { get; set; }
        }
        [HttpPost("FavoriteMovie")]
        public IActionResult FavoriteMovie([FromBody] YourFavoriteMovie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok($"Your favorite movie is: {movie.Title}");
        }

        [HttpGet("GetMySistersName")]
        public string GetMySistersName()
        {
            var SisterName = "Mary";
            return SisterName;
        }

        [HttpPost("ModelOfYourCar")]
        public string ModelOfYourCar(string model)
        {
            if (string.IsNullOrEmpty(model))
            {
                return "The Model of your car is required";
            }
            else
            {
                return model;
            }
        }

        [HttpPost("BestSoccerTeam")]
        public bool BestSoccerTeam(string Team)
        {
            if (Team == "São Paulo Fc")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet("GetFavoriteSport")]
        public string GetFavoriteSport()
        {
            var sport = "Soccer";
            return sport;
        }

        [HttpPost("YourFavoriteGame")]
        public IActionResult YourFavoriteGame(string game)
        {
            if (string.IsNullOrEmpty(game))
            {
                return BadRequest("Empty space");
            }
            else
            {
                return Ok(game);
            }
        }

        [HttpPost("SumAB")]
        public int SumAB(int A, int B)
        {
            return (A + B);
        }

        [HttpPost("TheBestGameOfPs5")]
        public bool TheBestGameOfPs5(string game)
        {
            if (game == "The Last Of Us I")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet("GetTop5Drinks")]
        public List<string> GetTop5Drinks()
        {
            var Top5Drink = new List<string>();
            var drink1 = "Heineken";
            var drink2 = "Black Label";
            var drink3 = "Jack Danniels";
            var drink4 = "Gin";
            var drink5 = "Caipirinha";

            Top5Drink.Add(drink1);
            Top5Drink.Add(drink2);
            Top5Drink.Add(drink3);
            Top5Drink.Add(drink4);
            Top5Drink.Add(drink5);

            return Top5Drink;
        }

        public class YourFavoriteSinger
        {
            [Required(ErrorMessage = "Singer name is required.")]
            [StringLength(30, ErrorMessage = "Singer name must contain a maximum of 30 characters")]
            public required string Singer { get; set; }
        }
        [HttpPost("FavoriteSinger")]
        public IActionResult FavoriteSinger(YourFavoriteSinger name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok($"Your favorite singer is: {name.Singer}");
        }

        [HttpPost("AppToListenToMusic")]
        public bool AppToListenToMusic(string app)
        {
            if (app == "Apple Music")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class GymEquipment
        {
            public required string Equipment { get; set; }
            public required int Quantity { get; set; }
        }

        [HttpGet("GetGymEquipment")]
        public List<GymEquipment> GetGymEquipment()
        {
            var GymEquipments = new List<GymEquipment>();
            var item1 = "Supino";
            var item2 = "Cross Over";
            var item3 = "Leg Press";
            var item4 = "Pack Deck";

            var Value1 = 3;
            var Value2 = 2;
            var Value3 = 2;
            var Value4 = 5;

            GymEquipments.Add(new GymEquipment { Equipment = item1, Quantity = Value1 });
            GymEquipments.Add(new GymEquipment { Equipment = item2, Quantity = Value2 });
            GymEquipments.Add(new GymEquipment { Equipment = item3, Quantity = Value3 });
            GymEquipments.Add(new GymEquipment { Equipment = item4, Quantity = Value4 });


            return GymEquipments;
        }

        [HttpPost("MyUniversity")]
        public bool MyUniversity(string university)
        {
            if (university == "Anhembi Morumbi")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public class TheMostFamousPodcast
        {
            [Required(ErrorMessage = "PodCast name is required.")]
            [StringLength(15, ErrorMessage = "PodCast name must contain a maximum of 15 characters")]
            public required string PodCast { get; set; }
        }
        [HttpPost("theMostFamousPodCast")]
        public IActionResult theMostFamousPodcast(TheMostFamousPodcast name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok($"Your favorite podcast is: {name.PodCast}");
        }

        [HttpPost("FavoriteFruit")]
        public bool FavoriteFruit(string fruit)
        {
            if (fruit == "Apple")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public class FirstLetter
        {
            [Required(ErrorMessage = "First letter is mandatory")]
            public required char? first { get; set; }
        }

        [HttpPost("FirstLetterOfMyName")]
        public IActionResult FirstLetterOfMyName(FirstLetter letter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Use only a single character.");
            }
            else
            {
                return Ok($"The First letter of my name is: {letter.first}");
            }
        }

        [HttpPost("FavoriteAnimal")]
        public bool FavoriteAnimal(string animal)
        {
            if (animal == "Dog")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public class InstrumentThatYouPlay
        {
            [Required(ErrorMessage = "Instrument name is required.")]
            public required string Instrument { get; set; }
        }
        [HttpPost("TheInstrumentThatYouPlay")]
        public IActionResult TheInstrumentThatYouPlay(InstrumentThatYouPlay name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok($"The Instrument that you play is : {name.Instrument}");
        }

        [HttpGet("GetYourFavoriteColor")]
        public string GetYourFavoriteColor(string color)
        {
            if (color == "Blue") 
            {
                return $"Your favorite color is: { color}";
            }
            else
            {
                return ("Wrong color");
            }
        }

        [HttpGet("GetYourFavoriteTrip")]
        public string GetYourFavoriteTrip(string trip)
        {
            if (trip == "Ceara")
            {
                return $"Your favorite Trip was: {trip}";
            }
            else
            {
                return ("Wrong place");
            }
        }

        [HttpPost("PlaceYouWantToTravel")]
        public bool PlaceYouWantToTravel(string place)
        {
            if (place == "USA")
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