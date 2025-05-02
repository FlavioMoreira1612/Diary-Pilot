using Microsoft.EntityFrameworkCore;
using diary_pilot.Models;

namespace diary_pilot.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<diary_pilot.Models.Tarefas> Tarefas { get; set; }

    }
}
