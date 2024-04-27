using Ecommerce.Repository.Models;
using Ecommerce.Utility.Encode;
using Ecommerce.Utility.Enum;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
