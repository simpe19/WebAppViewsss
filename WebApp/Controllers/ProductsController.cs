using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;
using WebApp.Views.Services;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {

        private readonly TagService _tagService;

        public ProductsController(TagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Register() 
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(ProductRegistrationViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

            }
            ViewBag.Tags = await _tagService.GetTagsAsync();
            return View();
        } 
    }
}
