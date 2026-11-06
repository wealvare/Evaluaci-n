using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Mapper;
using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Requets;
using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Response;
using WebAPI_2026._11._06_Wilber_Alvarez.Repository;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Services
{
    public class UsuarioService
    {
        private readonly UsuarioMapper _mapper;
        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioRepository repository, UsuarioMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<UsuarioResponseDto>> ObtenerTodo(){
            var usuarios = await _repository.GetAll();

            return usuarios.Select(u => _mapper.ToDto(u)).ToList();
        }

        public async Task<UsuarioResponseDto> ObtenerId(int id) {
            var usuarios = await _repository.Get(id);

            return _mapper.ToDto(usuarios);
        }

        public async Task<UsuarioResponseDto> Crear(UsuarioRequetsDto dto)
        {
            var usuario= _mapper.ToEntity(dto);
            var creado= await _repository.Save(usuario);

            return _mapper.ToDto(creado);
        }

    }
}
