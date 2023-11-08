using Microsoft.EntityFrameworkCore;

namespace FuarProjesi.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt):base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
