using Microsoft.EntityFrameworkCore;

namespace crudSystem.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Employes> Employes { get; set; }
    }
}
