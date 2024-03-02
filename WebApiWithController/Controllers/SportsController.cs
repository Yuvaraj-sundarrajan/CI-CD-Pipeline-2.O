using Microsoft.AspNetCore.Mvc;
using Tournament_Management_System.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiWithController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        private static List<Sportsmodal> Tournaments = new List<Sportsmodal>{ };

        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<Sportsmodal> GetTournament()
        {
            return Tournaments;
        }

        [HttpPost]
        public IActionResult PostTournament(Sportsmodal Tournament)
        {
            Tournaments.Add(Tournament);
            return Ok(Tournament);
        }       
    }
}
