using Microsoft.EntityFrameworkCore;
using UdemyCloneBackend.Models;

namespace UdemyCloneBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Definir seus DbSets aqui
        public DbSet<Curso> Cursos { get; set; }
    }
}
