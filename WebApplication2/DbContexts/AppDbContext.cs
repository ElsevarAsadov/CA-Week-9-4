using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.DbContexts;

public class AppDbContext : DbContext
{
    public DbSet<Slider> Slider { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Slider>().HasData(
            
            new {Id = 1, Title = "Title 1", Content = "Content 1"},
            new {Id = 2, Title = "Title 2", Content = "Content 2"}
            
            
        );
        
        
        base.OnModelCreating(modelBuilder);
    }
}