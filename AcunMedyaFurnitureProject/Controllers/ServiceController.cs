using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly FurniterContext _context;

        public ServiceController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Services = _context.Services.ToList();
            return View();
        }

        public PartialViewResult PartialAbout()
        {
            var values = _context.Services.ToList();
            return PartialView(values);

        }
    }
}
