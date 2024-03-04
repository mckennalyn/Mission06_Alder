using Microsoft.EntityFrameworkCore;

namespace Mission06_Alder.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Adventure" },
                new Category { CategoryId = 3, CategoryName = "Scientific" },
                new Category { CategoryId = 4, CategoryName = "Thriller" }

            );
        }
    }
}