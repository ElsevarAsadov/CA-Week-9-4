using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class AppDbContext : DbContext
{
    public DbSet<Hero> Hero { get; set; }
    public DbSet<Card> Card { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    
    
    
}