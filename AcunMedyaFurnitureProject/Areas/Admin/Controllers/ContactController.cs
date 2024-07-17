using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/{controller}/[action]/{id?}")]
    public class ContactController : Controller
    {
        private readonly FurniterContext _context;

        public ContactController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.ContactInfos.ToList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var value = _context.ContactInfos.Find(id);
            _context.ContactInfos.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(ContactInfo contactInfo)
        {
            _context.ContactInfos.Add(contactInfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateContact(int id)
        {
            var value = _context.ContactInfos.Find(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContact(ContactInfo contactInfo)
        {
            _context.ContactInfos.Update(contactInfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
