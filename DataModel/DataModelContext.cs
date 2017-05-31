using System.Data.Entity;

namespace DataModel
{
    public class DataModelContext : DbContext
    {
        public DataModelContext() : base("datamodel_db")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressUserLink> AddressUserLinks { get; set; }
    }
}