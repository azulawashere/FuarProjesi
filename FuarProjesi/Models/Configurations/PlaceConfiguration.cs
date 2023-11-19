using FuarProjesi.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuarProjesi.Models.Configurations
{
    public class PlaceConfiguration:BaseConfiguration<Place>
    {
        public override void Configure(EntityTypeBuilder<Place> builder)
        {
            base.Configure(builder);
            builder.HasMany(x=> x.Flats).WithOne(x => x.Place).HasForeignKey(x=> x.PlaceID).IsRequired();
        }
    }
}
