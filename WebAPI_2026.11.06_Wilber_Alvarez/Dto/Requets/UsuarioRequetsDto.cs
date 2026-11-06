using System.ComponentModel.DataAnnotations;
using WebAPI_2026._11._06_Wilber_Alvarez.Model.Enum;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Dto.Requets
{
    public class UsuarioRequetsDto
    {
        [Required(ErrorMessage ="El nombre es oblidatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage ="El correo es obligatorio")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage ="EL telefono es obligatorio")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage ="La contraceña es obligatoria")]
        public string Passaword { get; set; } = string.Empty;

        [Required(ErrorMessage ="El rol es obligatorio")]
        public Rol Rol { get; set; }
    }
}
