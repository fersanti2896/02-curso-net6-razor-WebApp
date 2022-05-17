using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazor.Data;
using WebAppRazor.Models;

namespace WebAppRazor.Pages.Cursos {
    public class CrearModel : PageModel {
        private readonly ApplicationDbContext context;

        public CrearModel(ApplicationDbContext context){
            this.context = context;
        }

        [BindProperty]
        public Curso Curso { get; set; }

        public void OnGet() {
        }

        public async Task<IActionResult> OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            Curso.DateCreation = DateTime.Now;

            context.Add(Curso);
            await context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
