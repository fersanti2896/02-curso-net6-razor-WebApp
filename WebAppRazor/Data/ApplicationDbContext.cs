using Microsoft.EntityFrameworkCore;
using WebAppRazor.Models;

namespace WebAppRazor.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }

        public DbSet<Curso> Cursos { get; set; }
    }
}
