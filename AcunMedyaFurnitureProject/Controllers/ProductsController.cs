using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly FurniterContext _context;

        public ProductsController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Products.ToList();
            return View(values);
        }
    }
}
