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
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthenticationService(UserManager<AppUser> userManager, AdressService adressService, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _adressService = adressService;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<bool> UserAlreadyExistsAsync(Expression<Func<AppUser, bool>> expression)
        {
            return await _userManager.Users.AnyAsync(expression);

        }
        public async Task<bool> RegisterUserAsync(RegisterViewModel viewModel)
        {
            AppUser appUser = viewModel;
                var roleName = "User";

            if (!await _roleManager.Roles.AnyAsync())
            {
                await _roleManager.CreateAsync(new IdentityRole("System Administrator"));
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            if (!await _userManager.Users.AnyAsync())
                roleName = "System Administrator";

            var result = await _userManager.CreateAsync(appUser, viewModel.Password);
            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, roleName);

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
