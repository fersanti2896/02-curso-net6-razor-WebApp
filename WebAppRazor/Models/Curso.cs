using System.ComponentModel.DataAnnotations;

namespace WebAppRazor.Models {
    public class Curso {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del curso no puede ser vacío!")]
        [Display(Name = "Nombre del Curso")]
        public string NameCourse { get; set; }

        [Required(ErrorMessage = "La cantidad de clases no puede ser vacío!")]
        [Display(Name = "Cantidad de Clases")]
        public int CountClass { get; set; }

        [Required(ErrorMessage = "El costo del curso no puede ser vacío!")]
        [Display(Name = "Costo")]
        public int Price { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime DateCreation { get; set; }
    }
}
