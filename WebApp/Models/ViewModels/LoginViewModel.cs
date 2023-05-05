
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.ViewModels;

public class LoginViewModel
{

    [DataType(DataType.EmailAddress)]
    [Display(Name = "E-mail")]
    [Required(ErrorMessage = "You must provide an email adress")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    [Required(ErrorMessage = "You must provide a password")]
    public string Password { get; set; } = null!;

    [Display(Name = "Keep me logged in")]
    public bool RememberMe { get; set; } = false;

    public string ReturnUrl { get; set; } = "/";
}
