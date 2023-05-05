using Microsoft.AspNetCore.Identity;
using WebApp.Models.Entities;

namespace WebApp.Contexts.Identity;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? CompanyName { get; set; }
    public string? ImageUrl { get; set; }

    public ICollection<UserAdressEntity> Adresses { get; set; } = new HashSet<UserAdressEntity>();

}
