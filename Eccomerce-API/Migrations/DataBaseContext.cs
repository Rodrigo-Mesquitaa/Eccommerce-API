using Eccomerce_API.ModelConfigs;
using Eccomerce_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Eccomerce_API.Migrations
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
          : base(options)
        {

        }


        public DbSet<CustomerModel> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
