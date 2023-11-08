using FuarProjesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuarProjesi.Models.Configurations
{
    public class FoodServiceConfiguration:BaseConfiguration<FoodService>
    {
        public override void Configure(EntityTypeBuilder<FoodService> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ServicePrice).HasColumnType("money");
        }
    }
}
