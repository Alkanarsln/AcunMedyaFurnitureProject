using AcunMedyaFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/{controller}/[action]/{id?}")]
    public class SubscriberController : Controller
    {
        private readonly FurniterContext _context;

        public SubscriberController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Subscribers.ToList();
            return View(values);
        }
        public IActionResult DeleteSubscriber(int id)
        {
            var value = _context.Subscribers.Find(id);
            _context.Subscribers.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
