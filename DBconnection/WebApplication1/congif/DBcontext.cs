using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.congif
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions option) : base(option) { }

        public DbSet<User> Users { get; set; }
    }
}
