using gqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace gqlServer.Data
{
    public class CakeContext : DbContext
    {
        public CakeContext(DbContextOptions<CakeContext> options) :base(options)
        {
            
        }

        public DbSet<Cake> Cake { get; set; }
        
        
    }
}