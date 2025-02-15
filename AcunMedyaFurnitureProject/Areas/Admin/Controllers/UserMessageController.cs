﻿using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/{controller}/[action]/{id?}")]
    public class UserMessageController : Controller
    {
        private readonly FurniterContext _context;

        public UserMessageController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.UserMessages.ToList();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _context.UserMessages.Find(id);
            _context.UserMessages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
