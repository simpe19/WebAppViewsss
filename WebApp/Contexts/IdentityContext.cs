﻿using Microsoft.AspNetCore.Identity;
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

    /*
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var roleId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid().ToString();
        

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = roleId,
                Name = "System Administrator",
                NormalizedName = "SYSTEM ADMINISTRATOR"
            }
        );

        var passwordHasher = new PasswordHasher<AppUser>();
        builder.Entity<AppUser>().HasData(new AppUser
        {
            Id = userId,
            FirstName = " ",
            LastName = " ",
            UserName = "administrator@domain.com",
            Email = "administrator@domain.com",
            PasswordHash = passwordHasher.HashPassword(null!, "Bytmig123!"),
        });
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = roleId,
            UserId = userId,
        });
    }
    */
}
