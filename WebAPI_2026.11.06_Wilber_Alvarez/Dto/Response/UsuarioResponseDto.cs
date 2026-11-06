using System.ComponentModel.DataAnnotations;
using WebAPI_2026._11._06_Wilber_Alvarez.Model.Enum;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Dto.Response
{
    public class UsuarioResponseDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public Rol Rol { get; set; }
    }
}
