using LibraryAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private List<Genre> _genres = new List<Genre>()
        {
            new Genre()
            {
                Id = 1,
                Name = "Dram"
            },
            new Genre()
            {
                Id = 2,
                Name = "Sci-Fi"
            },
            new Genre()
            {
                Id = 3,
                Name = "Horror"
            }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_genres);
        }
    }

}
