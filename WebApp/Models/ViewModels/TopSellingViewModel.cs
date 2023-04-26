namespace WebApp.Models.ViewModels
{
    public class TopSellingViewModel
    {
        public string Title { get; set; } = "";
        public IEnumerable<TopSellingItemViewModel> TopItem { get; set; } = null!;
    }
}
