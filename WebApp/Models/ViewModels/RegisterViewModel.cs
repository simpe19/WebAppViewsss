
using System.ComponentModel.DataAnnotations;
using WebApp.Contexts.Identity;
using WebApp.Models.Entities;

namespace WebApp.Models.ViewModels;

public class RegisterViewModel
{
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "You must provide a first name")]
    public string Firstname { get; set; } = null!;

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "You must provide a last name")]
    public string Lastname { get; set; } = null!;

    [Display(Name = "Street Name")]
    [Required(ErrorMessage = "You must provide a street name")]
    public string StreetName { get; set; } = null!;

    [Display(Name = "Postal Code")]
    [Required(ErrorMessage = "You must provide a postal code")]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City")]
    [Required(ErrorMessage = "You must provide a city")]
    public string City { get; set; } = null!;

    [Display(Name = "Mobile")]
    public string? Mobile { get; set; }

    [Display(Name = "Company")]
    public string? Company { get; set; }

    [DataType(DataType.EmailAddress)]
    [Display(Name = "E-mail")]
    [Required(ErrorMessage = "You must provide an email adress")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must provide an valid email adress")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    [Required(ErrorMessage = "You must provide a password")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s])[a-zA-Z\d\W]{8,}$", ErrorMessage = "You must provide a valid password")]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Required(ErrorMessage = "You must confirm your password")]
    public string ConfirmPassword { get; set; } = null!;

    [DataType(DataType.Upload)]
    [Display(Name = "Upload Profile Image")]
    public IFormFile? ImageFile { get; set; }

    [Display(Name = "I have read and accepts the terms and agreements  ")]
    [Required(ErrorMessage = "You must accept the terms")]
    public bool TermsAndAgreement { get; set; } = false;

    public static implicit operator AppUser(RegisterViewModel viewModel)
    {
        return new AppUser
        {
        UserName = viewModel.Email,
        FirstName = viewModel.Firstname,
        LastName = viewModel.Lastname,
        Email = viewModel.Email,
        PhoneNumber = viewModel.Mobile,
        CompanyName = viewModel.Company
        };
    }
    public static implicit operator AdressEntity(RegisterViewModel viewModel)
    {
        return new AdressEntity
        {
            StreetName = viewModel.StreetName,
            PostalCode = viewModel.PostalCode,
            City = viewModel.City
        };
    }
}
