using FuarProjesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuarProjesi.Models.Configurations
{
    public class PackageConfiguration:BaseConfiguration<Package>
    {
        public override void Configure(EntityTypeBuilder<Package> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UnitPrice).HasColumnType("money");
         
        }

    }
}
