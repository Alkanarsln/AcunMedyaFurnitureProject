using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly FurniterContext _context;

        public AboutController(FurniterContext context)
        {
            _context = context;
        }
      

        public IActionResult Index()
        {
            ViewBag.Abouts = _context.Abouts.ToList();
            ViewBag.Testimonials = _context.Testimonials.ToList();
            ViewBag.Teams = _context.Teams.ToList();
            return View();
        }
        public PartialViewResult PartialService()
        {
            var values = _context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTeam()
        {
            var values = _context.Teams.ToList();   
            return PartialView();
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = _context.Testimonials.ToList();
            return PartialView(values);
        }
    }
}
