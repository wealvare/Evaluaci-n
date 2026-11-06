using Microsoft.EntityFrameworkCore;
using WebAPI_2026._11._06_Wilber_Alvarez.Model;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

