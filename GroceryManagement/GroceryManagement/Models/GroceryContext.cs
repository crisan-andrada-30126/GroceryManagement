using Microsoft.EntityFrameworkCore;
namespace GroceryManagement.Models;
public class GroceryContext : DbContext
{
    public GroceryContext(DbContextOptions<GroceryContext> options)
       : base(options)
    {
    }

    public DbSet<GroceryItem> GroceryItems { get; set; } = null!;
    public DbSet<User> Users { get; set; }
}


