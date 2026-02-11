using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;
namespace WebApplication1.DBConfig
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }  
    }
}
