using Liga_piłkarska.Models;
using Liga_piłkarska.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Liga_piłkarska.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }


        // GET: TeamController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var teams = _teamService.GetTeams();
            return View(teams);
        }

        public IActionResult Details(int id) 
        {
            var team = _teamService.GetById(id);
            return View(team.Players);
        }

       public IActionResult Add()
        {

            return View();
        }
    }
}
