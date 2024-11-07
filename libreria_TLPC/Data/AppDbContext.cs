using libreria_TLPC.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace libreria_TLPC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
    }
}
