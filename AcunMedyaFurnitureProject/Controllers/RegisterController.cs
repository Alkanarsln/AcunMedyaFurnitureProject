using AcunMedyaFurnitureProject.DataAccess.Entities;
using AcunMedyaFurnitureProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public  IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            var user = new AppUser
            {
                UserName = registerViewModel.UserName,
                Email = registerViewModel.Email,
                NameSurname = registerViewModel.NameSurname
            };

            var result = await _userManager.CreateAsync(user , registerViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.Code, item.Description);
            }
            return View();
        }
    }
}
