using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Requets;
using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Response;
using WebAPI_2026._11._06_Wilber_Alvarez.Model;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Dto.Mapper
{
    public class UsuarioMapper
    {
        public Usuario ToEntity(UsuarioRequetsDto dto)
        {
            return new Usuario
            {
                Nombre = dto.Nombre,
                Telefono = dto.Telefono,
                Email = dto.Email,
                Passaword = dto.Passaword,
                Rol = dto.Rol
            };
        }

        public UsuarioResponseDto ToDto(Usuario entity)
        {
            return new UsuarioResponseDto
            {

                Id = entity.Id,
                Nombre = entity.Nombre,
                Telefono= entity.Telefono,
                Email = entity.Email,

            };
        }
    }
}
