namespace WebApp.Models.ViewModels;

public class BestCollectionViewModel
{
    public string Title { get; set; } = "";
    public IEnumerable<string> Categories { get; set; } = null!;
    public IEnumerable<BestCollectionItemViewModel> GridItems { get; set; } = null!;
    public bool LoadMore { get; set; } = false!;
}
