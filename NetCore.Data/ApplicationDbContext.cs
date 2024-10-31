using Microsoft.EntityFrameworkCore;
using NetCore.Data.Entities;

namespace NetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Burada DbSet'leri tanımlayın
        public DbSet<User> Users { get; set; }
    }
}
