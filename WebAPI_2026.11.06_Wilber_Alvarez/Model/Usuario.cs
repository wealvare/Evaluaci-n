using System.ComponentModel.DataAnnotations;
using WebAPI_2026._11._06_Wilber_Alvarez.Model.Enum;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; }= string.Empty;

        [Required]
        public string Telefono {  get; set; } = string.Empty;

        [Required]
        public string Passaword {  get; set; } = string.Empty;

        [Required]
        public Rol Rol { get; set; }
    }
}
