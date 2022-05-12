using BasicApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Contexts
{
    public class BasicDbContext : DbContext, IBasicDbContext
    {
        private readonly IConfiguration _configuration;

        public BasicDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(_configuration.GetConnectionString("BasicApiMsSqlDatabase"));
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Affiliate> Affiliates { get; set; }
    }
}
