using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class DbSeedingContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnectionString"));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hero>().HasData(

            new { Id= 1, Title = "Title 1", Desc = "Desc 1"},
            new { Id= 2, Title = "Title 2", Desc = "Desc 2"},
            new { Id= 3, Title = "Title 3", Desc = "Desc 3"}
            
        );


        modelBuilder.Entity<Card>().HasData(
            new {Id = 1, Title = "Cad Title 1", Content = "Card Content 1"},
            new {Id = 2, Title = "Cad Title 2", Content = "Card Content 2"},
            new {Id = 3, Title = "Cad Title 3", Content = "Card Content 3"},
            new {Id = 4, Title = "Cad Title 4", Content = "Card Content 4"}
        );
        
        base.OnModelCreating(modelBuilder);
    }
}