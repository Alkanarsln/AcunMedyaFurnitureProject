using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
    public class _DefaultTestimonialComponent :ViewComponent
    {
        private readonly FurniterContext _context;

        public _DefaultTestimonialComponent(FurniterContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }
    }
}
