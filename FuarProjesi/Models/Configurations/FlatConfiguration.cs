using FuarProjesi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuarProjesi.Models.Configurations
{
    public class FlatConfiguration:BaseConfiguration<Flat>
    {
        public override void Configure(EntityTypeBuilder<Flat> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.FlatPrice).HasColumnType("money") ;
        }
    }
}
