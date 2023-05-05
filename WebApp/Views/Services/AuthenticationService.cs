using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Contexts.Identity;
using WebApp.Models.ViewModels;

namespace WebApp.Views.Services
{
    public class AuthenticationService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AdressService _adressService;

        public AuthenticationService(UserManager<AppUser> userManager, AdressService adressService, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _adressService = adressService;
            _signInManager = signInManager;
        }

        public async Task<bool> UserAlreadyExistsAsync(Expression<Func<AppUser, bool>> expression)
        {
            return await _userManager.Users.AnyAsync(expression);

        }
        public async Task<bool> RegisterUserAsync(RegisterViewModel viewModel)
        {
            AppUser appUser = viewModel;

            var result = await _userManager.CreateAsync(appUser, viewModel.Password);
            if(result.Succeeded)
            {
                var adressEntity = await _adressService.GetOrCreateAsync(viewModel);
                if(adressEntity != null)
                {
                    await _adressService.AddAdressAsync(appUser, adressEntity);
                    return true;
                }               
            }

            return false;
        }

        public async Task<bool> LoginAsync(LoginViewModel viewModel)
        {
            var appUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email); 
            if (appUser != null)
            {
               var result = await _signInManager.PasswordSignInAsync(appUser, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;
            }
            return false;
        }
    }
}
