using AcunMedyaFurnitureProject.DataAccess.Entities;
using AcunMedyaFurnitureProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaFurnitureProject.Controllers
{
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]

		public async Task<IActionResult> Index(LoginViewModel loginViewModel)
		{
			var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.password, false, false);
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Product", new { area = "Admin" });
			}
			ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
			return View();
		}

		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Login");
		}
	}
}
