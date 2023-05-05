using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Contexts.Identity;
using WebApp.Models.Entities;

namespace WebApp.Contexts;

public class IdentityContext : IdentityDbContext<AppUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {
    }

    public DbSet<AdressEntity> AspNetAdresses { get; set; }
    public DbSet<UserAdressEntity> AspNetUsersAdresses { get; set; }
}
