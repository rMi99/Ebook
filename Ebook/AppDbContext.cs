// Namespace for your project - helps organize code and avoid name conflicts
using Microsoft.EntityFrameworkCore;
using Ebook.Models;

namespace Ebook
{
    // AppDbContext: This class will be used to interact with the database using Entity Framework Core.
    // It will inherit from DbContext and contain DbSet<T> properties for each table/model.
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) // Dependacy inject
        {

        }
        //public DbSet<Student> students { get; set; } // if Existing 
        //public DbSet<Lecturer> Leturer { get; set; } // if Existing 

        public DbSet<Book> Book { get; set; }

        // TODO: Define DbSets for your models
        // Example:
        // public DbSet<User> Users { get; set; }

        // TODO: Optionally override OnModelCreating to configure model relationships, constraints, etc.


    }
}
