using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "Du måste ange en Email")]
    [Display(Name = "Email")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Du måste ange ett lösenord")]
    [Display(Name = "Lösenord")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
}
