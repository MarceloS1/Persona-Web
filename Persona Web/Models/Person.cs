using System.ComponentModel.DataAnnotations;

namespace Persona_Web.Models
{
    public enum SexType 
    {
        Female = 0,
        Male = 1,
    }
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        [StringLength(60,MinimumLength = 5, ErrorMessage = "Por favor ingrese entre 5 a 60 caracteres")]
        [Display(Name ="Nombre de la Persona")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Sexo")]
        public SexType Sex { get; set; }
        [Display(Name = "Pasa Tiempo")]
        public string Hobbie { get; set; }
    }

}
