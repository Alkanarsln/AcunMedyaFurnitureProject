using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Route("[area]/{controller}/[action]/{id?}")]
	public class TeamController : Controller
    {
        private readonly FurniterContext _context;

        public TeamController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Teams.ToList();
            return View(values);
        }
        public IActionResult DeleteTeam(int id)
        {
            var value = _context.Teams.Find(id);
            _context.Teams.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeam(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateTeam(int id)
        {
            var value = _context.Teams.Find(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            _context.Teams.Update(team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
