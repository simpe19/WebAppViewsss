using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.Models.ViewModels
{
    public class ProductRegistrationViewModel
    {

        public string ArticleNumber { get; set; } = null!;

        [Required(ErrorMessage = "Du måste ange ett produktnamn")]
        [Display(Name = "Produktnamn *")]
        public string Name { get; set; } = null!;

        [Display(Name = "Produkt beskrivning (valfritt)")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Du måste ange ett produktpris")]
        [Display(Name = "Produktpris *")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }



        public static implicit operator ProductEntity(ProductRegistrationViewModel viewModel)
        {
            return new ProductEntity
            {
                ArticleNumber = viewModel.ArticleNumber,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price
            };
        }
    }

}
