using Microsoft.AspNetCore.Mvc;

using WebApp.Models.ViewModels;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        var viewModel = new HomeIndexViewModel
        {
            BestCollection = new BestCollectionViewModel 
            { 
                Title = "Best Collection",
                Categories = new List<string> { "All", "Bag", "Dress", "Decoration", "Essentials"},
                GridItems = new List<BestCollectionItemViewModel> 
                {
                    new BestCollectionItemViewModel { Id = "1" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"},
                    new BestCollectionItemViewModel { Id = "2" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"},
                    new BestCollectionItemViewModel { Id = "3" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"},
                    new BestCollectionItemViewModel { Id = "4" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"},
                    new BestCollectionItemViewModel { Id = "5" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"},
                    new BestCollectionItemViewModel { Id = "6" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"},
                    new BestCollectionItemViewModel { Id = "7" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"},
                    new BestCollectionItemViewModel { Id = "8" , Title = "Apple watch collection", Price = 30, ImageUrl = "images/placeholders/270x295.svg"}
                }


            },

            UpToSell = new UpToSellViewModel 
            {
                Title = "Up To Sell",
                UpToSellItems = new List<UpToSellItemViewModel>
                {
                    new UpToSellItemViewModel { Id = "1" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/369x310.svg" , Price = 30},
                    new UpToSellItemViewModel { Id = "2" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/369x310.svg" , Price = 30}
                }
            },

            TopSell = new TopSellingViewModel
            {
                Title = "Top selling products in this week",
                TopItem = new List<TopSellingItemViewModel>
                {
                    new TopSellingItemViewModel {Id = "1" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/270x295.svg" , Price = 30 },
                    new TopSellingItemViewModel {Id = "2" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/270x295.svg" , Price = 30 },
                    new TopSellingItemViewModel {Id = "3" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/270x295.svg" , Price = 30 },
                    new TopSellingItemViewModel {Id = "4" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/270x295.svg" , Price = 30 },
                    new TopSellingItemViewModel {Id = "5" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/270x295.svg" , Price = 30 },
                    new TopSellingItemViewModel {Id = "6" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/270x295.svg" , Price = 30 },
                    new TopSellingItemViewModel {Id = "7" , Title = "Apple watch collection" , ImageUrl = "images/placeholders/270x295.svg" , Price = 30 }
                }
            }
        };
        return View(viewModel);
    }
}
