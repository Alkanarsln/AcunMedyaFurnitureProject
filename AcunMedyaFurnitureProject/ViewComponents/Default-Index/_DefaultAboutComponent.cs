using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
    public class _DefaultAboutComponent : ViewComponent
    {
        private readonly FurniterContext _context;

        public _DefaultAboutComponent(FurniterContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
