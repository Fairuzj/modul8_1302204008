using Microsoft.AspNetCore.Mvc;

namespace modul8_1302204008.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public static List<string> movie1 = new List<string>() { "Tim Robbins",
                                                                "Morgan Freeman",
                                                                "Bob Gunton",
                                                                "William Sadler" };
        
        public static List<string> movie2 = new List<string>() { "Marlon Brando", 
                                                                "Al Pacino", 
                                                                "James Caan", 
                                                                "Diane Keaton" };

        public static List<string> movie3 = new List<string>() { "Christian Bale", 
                                                                "Heath Ledger", 
                                                                "Aaron Eckhart", 
                                                                "Michael Caine" };

        public static List<Movies> movies = new List<Movies>()
        {
            new Movies("The Shawshank Redemption", "Frank Darabont", movie1,
                "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movies("The Godfather", "Francis Ford Coppola", movie2,
                "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movies("The Dark Knight", "Christopher Nolan", movie3,
                "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."),
        };
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return movies[id];
        }

        [HttpPost]
        public void Post([FromBody] Movies value)
        {
            movies.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);
        }
    }
}
