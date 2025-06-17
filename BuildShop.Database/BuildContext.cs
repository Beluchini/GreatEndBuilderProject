using BuildShop.Model;
using Microsoft.EntityFrameworkCore;


namespace BuildShop.Database;

public class BuildContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<RecordOfProduct> RecordOfProducts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Basket> Baskets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=BuildShop.db");
    }
}