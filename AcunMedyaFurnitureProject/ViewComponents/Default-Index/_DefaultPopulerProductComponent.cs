using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
    public class _DefaultPopulerProductComponent : ViewComponent
    {
        private readonly FurniterContext _context;

        public _DefaultPopulerProductComponent(FurniterContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Products.Where(x=>x.Status == true).ToList();
            return View(values);
        }
    }
}
