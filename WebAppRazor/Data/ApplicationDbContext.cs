using Microsoft.EntityFrameworkCore;

namespace WebAppRazor.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }
    }
}
