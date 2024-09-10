using Microsoft.EntityFrameworkCore;
using UdemyCloneBackend.Models;

namespace UdemyCloneBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }  // Adicionando Users ao contexto
        public DbSet<Curso> Cursos { get; set; }
    }
}
