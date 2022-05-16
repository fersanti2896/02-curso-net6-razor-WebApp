using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppRazor.Data;
using WebAppRazor.Models;

namespace WebAppRazor.Pages.Cursos {
    public class IndexModel : PageModel {

        private readonly ApplicationDbContext context;

        public IndexModel(ApplicationDbContext context) {
            this.context = context;
        }

        public IEnumerable<Curso> Cursos { get; set; }

        public async Task OnGet() {
            Cursos = await context.Cursos.ToListAsync();
        }
    }
}
