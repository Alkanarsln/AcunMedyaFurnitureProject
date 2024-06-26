using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/{controller}/[action]/{id?}")]
	[Authorize]
	public class ProductController : Controller
	{
		private readonly FurniterContext _context;

		public ProductController(FurniterContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.Products.ToList();
			return View(values);
		}

		public IActionResult DeleteProduct(int id)
		{
			var values =_context.Products.Find(id);
			_context.Products.Remove(values);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult CreateProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateProduct(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateProduct(int id)
		{
			var values = _context.Products.Find(id);
			return View(values); 
		}

		[HttpPost]
		public IActionResult UpdateProduct(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
