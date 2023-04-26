using WebApp.Models;

namespace WebApp.Views.Services;

public class ShowcaseService
{
    private readonly List<ShowcaseModel> _showcases = new() 
    {
        new ShowcaseModel()
        {
            Ingress = "WELCOME TO BMERKETO SHOP",
            Title = "Exclusive Chair gold Collection.",
            ImageUrl = "images/placeholders/625x647.svg",
            LinkUrl = "/Products",
            LinkContent = "SHOP NOW"
        } 
    
    };
    

    public ShowcaseModel GetLatest()
    {
        return _showcases.LastOrDefault()!;
    }
}
