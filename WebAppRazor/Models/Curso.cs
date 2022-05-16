using System.ComponentModel.DataAnnotations;

namespace WebAppRazor.Models {
    public class Curso {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre del Curso")]
        public string NameCourse { get; set; }
        [Display(Name = "Cantidad de Clases")]
        public int CountClass { get; set; }
        [Display(Name = "Costo")]
        public int Price { get; set; }
        [Display(Name = "Fecha de Creación")]
        public DateTime DateCreation { get; set; }
    }
}
