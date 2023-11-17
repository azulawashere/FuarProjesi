using FuarProjesi.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FuarProjesi.Models.Extentions
{
    public static class DataSeedExtension
    {
        
        public static async void Seed(this ModelBuilder modelBuilder)
        {
            AppUser appUser = new AppUser
            {
                Id=1,
                UserName="deneme",
                 
            };
           AppRole c = new AppRole();
            c.Name = "Admin";
            c.Id = 1;
            AppRole m = new AppRole();
            m.Name = "Member";
            m.Id = 2;


            AppUserRole appUserRole = new AppUserRole();
            appUserRole.UserId = appUser.Id;
            appUserRole.RoleId = c.Id;
           
            modelBuilder.Entity<AppRole>().HasData(c);
            modelBuilder.Entity<AppRole>().HasData(m);
            modelBuilder.Entity<AppUser>().HasData(appUser);
            modelBuilder.Entity<AppUserRole>().HasData(appUserRole);
        }

    }
}
