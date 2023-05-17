using Microsoft.EntityFrameworkCore;

namespace AccProductsEnt.Kuriev.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        
    }
}
