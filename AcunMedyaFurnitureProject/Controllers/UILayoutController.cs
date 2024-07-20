using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
    public class UILayoutController : Controller
    {
        private readonly FurniterContext _context;

        public UILayoutController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Subscribe()
        {
            var subscriber = new Subscriber();
            return PartialView(subscriber);
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                // Abone oluşturma işlemini gerçekleştir
                _context.Subscribers.Add(subscriber);
                await _context.SaveChangesAsync();

                // Abone kimliğini al
                int subscriberId = subscriber.SubscriberID;
                TempData["SubscriberID"] = subscriberId; // Kimliği TempData'ya kaydedin
                return RedirectToAction("Index", "Default");
            }
            return View(subscriber);
        }

        public IActionResult SubscribeSuccess()
        {
            if (TempData["SubscriberID"] != null)
            {
                ViewBag.SubscriberID = TempData["SubscriberID"];
                return View();
            }
            return RedirectToAction("Subscribe");
        }
    }
}
