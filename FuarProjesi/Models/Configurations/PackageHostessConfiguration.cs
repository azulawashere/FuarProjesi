using FuarProjesi.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuarProjesi.Models.Configurations
{
    public class PackageHostessConfiguration:BaseConfiguration<PackageHostess>
    {
        public override void Configure(EntityTypeBuilder<PackageHostess> builder)
        {
            base.Configure(builder);
            builder.Ignore(x=>x.ID);
            builder.HasKey(x => new
            {
                x.PackageID,
                x.HostessID
            });
        }
    }
}
