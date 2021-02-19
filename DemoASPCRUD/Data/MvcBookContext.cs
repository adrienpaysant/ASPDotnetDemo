using DemoASPCRUD.Models;
using Microsoft.EntityFrameworkCore;


namespace DemoASPCRUD.Data
{
    
    public class MvcBookContext : DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }


    }
}