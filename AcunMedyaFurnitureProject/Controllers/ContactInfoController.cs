using AcunMedyaFurnitureProject.DataAccess.Context;
using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
	public class ContactInfoController : Controller
	{
		private readonly FurniterContext _context;

        public ContactInfoController(FurniterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
			ViewBag.Contact = _context.ContactInfos.ToList();
			return View();
		}

		public PartialViewResult ContactList()
		{
			var values = _context.ContactInfos.ToList();
			return PartialView(values);
		}

		public PartialViewResult CreateMessage()
		{
			var message = new UserMessage();
			return PartialView(message);
		}
		[HttpPost]
		public async Task<IActionResult> CreateMessage(UserMessage userMessage)
		{
			if (ModelState.IsValid)
			{
				_context.UserMessages.Add(userMessage);
				await _context.SaveChangesAsync();

				int usermessageId = userMessage.UserMessageID;
				TempData["UserMessageID"] = usermessageId;
				return RedirectToAction("Index","Default");
			}
			return View(userMessage);
		}

		public IActionResult UserMessageSuccess()
		{
			if (TempData["UserMessageID"] != null)
			{
				ViewBag.UserMessageID = TempData["UserMessageID"];
				return View();
			}
			return RedirectToAction("CreateMessage");
		}
	}
}
