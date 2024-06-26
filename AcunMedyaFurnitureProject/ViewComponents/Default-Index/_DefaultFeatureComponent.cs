using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
    public class _DefaultFeatureComponent : ViewComponent
    {
        private readonly FurniterContext _context;

        public _DefaultFeatureComponent(FurniterContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}
