using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Contexts;
using WebApp.Models.Entities;
using WebApp.Models.ViewModels;
using WebApp.Views.Services;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _userService.UserExists(x => x.Email == registerViewModel.Email))
                {
                    ModelState.AddModelError("", "Användaren finns redan");
                }
                else
                {
                    if (await _userService.CreateAsync(registerViewModel))
                        return RedirectToAction("Account", "Index");
                    else
                        ModelState.AddModelError("", "Något gick fel");
                }
            }
            return View(registerViewModel);

        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
           

            if (ModelState.IsValid)
            {
                if (await _userService.LoginAsync(loginViewModel))
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Felaktig e-postadress eller lösenord");
            }


            return View(loginViewModel);
        }
    }
}
