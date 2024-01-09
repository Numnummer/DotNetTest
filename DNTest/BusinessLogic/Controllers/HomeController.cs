using BusinessLogic.Database;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Diagnostics;

namespace BusinessLogic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GameDbContext _gameDbContext;

        public HomeController(ILogger<HomeController> logger, GameDbContext gameDbContext)
        {
            _logger = logger;
            _gameDbContext = gameDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] Player player)
        {
            var random = new Random();
            var elementCount = await _gameDbContext.Monsters.CountAsync();
            var monster = await _gameDbContext.Monsters.ElementAtOrDefaultAsync(random.Next(elementCount));
            var arena = new Arena();
            var log = arena.Fight(player, monster);
            return Json(log);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
