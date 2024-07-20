using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/{controller}/[action]/{id?}")]
    public class TestimonialController : Controller
    {
        private readonly FurniterContext _context;

        public TestimonialController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        { 
            var values = _context.Testimonials.ToList();
            return View(values);
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Update(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
