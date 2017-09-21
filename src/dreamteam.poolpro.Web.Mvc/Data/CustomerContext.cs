
using dreamteam.poolpro.Web.Models.Customer;
using Microsoft.EntityFrameworkCore;

namespace dreamteam.poolpro.Web.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<BillingAddress> BillingAddress { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<LineItem> LineItem { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Quote> Quote { get; set; }
        public DbSet<Residence> Residence {get; set;}



    }
}
