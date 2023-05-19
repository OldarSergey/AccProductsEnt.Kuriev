using AccProductsEnt.Kuriev.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccProductsEnt.Kuriev.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        
        public DbSet<WriteOff> WriteOff { get; set; }
        public DbSet<Workshop> Workshop { get; set; }
        public DbSet<TechnicalProcesses> TechnicalProcesses { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Raw> Raw { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Implementation> Implementation { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Accounting> Accounting { get; set; }
        public DbSet<AccountCard> AccountCard { get; set; }
    }
}
