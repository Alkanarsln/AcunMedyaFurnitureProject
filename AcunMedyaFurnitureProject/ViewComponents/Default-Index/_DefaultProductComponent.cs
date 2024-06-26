using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaFurnitureProject.ViewComponents.Default_Index
{
    public class _DefaultProductComponent : ViewComponent
    {
        private readonly FurniterContext _context;

        public _DefaultProductComponent(FurniterContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Products.OrderByDescending(x => x.ProductID).Take(3).ToList();
            return View(values);
        }
    }
}
