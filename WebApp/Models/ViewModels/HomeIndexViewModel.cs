namespace WebApp.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public string Title { get; set; } = "Home";
        public BestCollectionViewModel BestCollection { get; set; } = null!;
        public UpToSellViewModel UpToSell { get; set; } = null!;
        public TopSellingViewModel TopSell { get; set; } = null!;
    }
}
