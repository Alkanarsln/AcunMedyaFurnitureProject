using AcunMedyaFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Areas.Admin.ViewComponents.AdminLayoutComponent
{
    public class _AdminNavbarLayoutComponenet : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

		public _AdminNavbarLayoutComponenet(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task <IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = user.NameSurname;
            ViewBag.ImageUrl = user.ImageUrl;
            
               return View();
        }
    }
}
