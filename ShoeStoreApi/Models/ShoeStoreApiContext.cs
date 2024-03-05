using Microsoft.EntityFrameworkCore;

namespace ShoeStoreApi.Models
{
  public class ShoeStoreApiContext : DbContext
  {
    public DbSet<Shoe> Shoes { get; set; }

    public ShoeStoreApiContext(DbContextOptions<ShoeStoreApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shoe>()
      .HasData(
        new Shoe { ShoeId = 1, Name = "Bred Reimagined", Brand = "Jordan", Colors = "Black/Red" },
        new Shoe { ShoeId = 2, Name = "Air Force 1", Brand = "Nike", Colors = "Brown" },
        new Shoe { ShoeId = 3, Name = "Slide", Brand = "Yeezy", Colors = "Slate Grey" },
        new Shoe { ShoeId = 4, Name = "Campus 00s", Brand = "Adidas", Colors = "Core Black" },
        new Shoe { ShoeId = 5, Name = "PLAY", Brand = "Converse", Colors = "Black" }
      );
    }
  }
}