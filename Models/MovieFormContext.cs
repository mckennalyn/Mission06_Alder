using Microsoft.EntityFrameworkCore;

namespace Mission06_Alder.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
        }

        public DbSet<Form> Forms { get; set; }
    }
}