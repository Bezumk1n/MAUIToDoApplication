using MAUIToDoApplication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MAUIToDoApplication.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
