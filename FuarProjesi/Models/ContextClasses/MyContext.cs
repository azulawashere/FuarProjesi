using FuarProjesi.Models.Configurations;
using FuarProjesi.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FuarProjesi.Models.ContextClasses
{
    public class MyContext :IdentityDbContext<AppUser, AppRole,int,IdentityUserClaim<int>,AppUserRole,IdentityUserLogin<int>,IdentityRoleClaim<int>,IdentityUserToken<int>>
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FlatConfiguration());
            modelBuilder.ApplyConfiguration(new FoodServiceConfiguration());
            modelBuilder.ApplyConfiguration(new HostessConfiguration());
            modelBuilder.ApplyConfiguration(new PackageConfiguration());
            modelBuilder.ApplyConfiguration(new PlaceConfiguration());
            modelBuilder.ApplyConfiguration(new PackageHostessConfiguration());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }              
        public DbSet<Category> Categories { get; set; }
        public DbSet<PackageHostess> PackageHostesses { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Hostess> Hostesses { get; set; }
        public DbSet<FoodService> FoodServices { get; set; }
        
    }
}
