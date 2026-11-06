using Microsoft.AspNetCore.Mvc;
using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Requets;
using WebAPI_2026._11._06_Wilber_Alvarez.Dto.Response;
using WebAPI_2026._11._06_Wilber_Alvarez.Services;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Data
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController: ControllerBase
    {
        private readonly UsuarioService _service;

        public UsuarioController(UsuarioService service) { 
            _service = service;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            try
            {
                return Ok(await _service.ObtenerId(id));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            try
            {
                return Ok(await _service.ObtenerTodo());
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { mensaje = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> crear(UsuarioRequetsDto dto)
        {
            try
            {
                var usuario = await _service.Crear(dto);

                return CreatedAtAction(
                    nameof(ObtenerPorId),
                    new { id = usuario.Id },
                    usuario);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { mensaje = ex.Message });
            }
        }
    }
}
