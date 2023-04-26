namespace WebApp.Models.ViewModels;

public class UpToSellViewModel
{
    public string Title { get; set; } = "";
    public IEnumerable<UpToSellItemViewModel> UpToSellItems { get; set; } = null!;
}
