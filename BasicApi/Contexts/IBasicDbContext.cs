using BasicApi.Model;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Contexts
{
    public interface IBasicDbContext
    {
        DbSet<Affiliate> Affiliates { get; set; }
        DbSet<Customer> Customers { get; set; }
    }
}