﻿using AcunMedyaFurnitureProject.DataAccess.Context;
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
            ViewBag.Products = _context.Products.ToList();
            return View();
        }

        public PartialViewResult PartialProduct()
        {
            var values = _context.Products.ToList();
            return PartialView(values);
        }
    }
}
