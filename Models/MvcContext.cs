using Microsoft.EntityFrameworkCore;

namespace demomvc.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        
        public DbSet<demomvc.Models.Usuario> Usuario { get; set; }
    }
}