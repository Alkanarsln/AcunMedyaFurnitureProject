using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/{controller}/[action]/{id?}")]
    public class AboutController : Controller
    {
        private readonly FurniterContext _context;

        public AboutController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
        public IActionResult DeleteAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateAbout(int id)
        {
            var value = _context.Abouts.Find(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
