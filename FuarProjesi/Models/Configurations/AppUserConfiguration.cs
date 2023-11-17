using FuarProjesi.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuarProjesi.Models.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Profile).WithOne(x=>x.AppUser).HasForeignKey<AppUserProfile>(x=>x.ID) ;
            builder.Ignore(x=>x.ID);
            builder.HasMany(x=>x.Packages).WithOne(x=>x.AppUser).HasForeignKey(x=>x.AppUserID);
            builder.HasMany(x=>x.UserRoles).WithOne(x=>x.User).HasForeignKey(x=>x.UserId).IsRequired();
        }
    }
}
