using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;

namespace WebApp.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Du måste ange ett förnamn")]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; } = null!;


        [Required(ErrorMessage = "Du måste ange ett efternamn")]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; } = null!;



        [Required(ErrorMessage = "Du måste ange en email adress")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Du måste ange en giltig e-postadress")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Du måste ange ett lösenord")]
        [Display(Name = "Lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set;} = null!;


        [Required(ErrorMessage = "Du måste bekräfta ditt lösenord")]
        [Compare(nameof(Password), ErrorMessage = "Lösenordet matchar inte")]
        [Display(Name = "Bekräfta lösenord")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;


        [Display(Name = "Gatunamn")]
        public string? StreetName { get; set; } 


        [Display(Name = "Postnummer")]
        public string? PostalCode { get; set; } 


        [Display(Name = "Stad")]
        public string? City { get; set; }


        public static implicit operator UserEntity(RegisterViewModel registerViewModel)
        {
            var userEntity = new UserEntity{ Email = registerViewModel.Email };
            userEntity.GenerateSecurePassword(registerViewModel.Password);
            return userEntity;
        }

        public static implicit operator ProfileEntity(RegisterViewModel registerViewModel)
        {
            return new ProfileEntity
            {
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName,
                StreetName = registerViewModel.StreetName,
                PostalCode = registerViewModel.PostalCode,
                City = registerViewModel.City
            };
        }
    }
}
