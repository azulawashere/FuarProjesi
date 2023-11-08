using FuarProjesi.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuarProjesi.Models.Configurations
{
    public class HostessConfiguration:BaseConfiguration<Hostess>
    {
        public override void Configure(EntityTypeBuilder<Hostess> builder)
        {
            base.Configure(builder);
        }
    }
}
