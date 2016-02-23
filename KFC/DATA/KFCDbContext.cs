using KFC.models;
using System.Data.Entity;

namespace KFC.DATA
{
    public class KFCDbContext : DbContext
    {
        public KFCDbContext()
            : base(@"Server=1203_02PC\SQLEXPRESS120302;Database=KFCDbContext;Trusted_Connection=True;")
        {
        }

        //
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<IngredientForm> Ingredients { get; set; }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
