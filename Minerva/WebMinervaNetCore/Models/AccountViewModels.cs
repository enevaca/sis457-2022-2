using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace WebMinervaNetCore.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string usuario { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        public string clave { get; set; }
        [Display(Name = "Recordarme")]
        public bool recordarme { get; set; }
    }
}
