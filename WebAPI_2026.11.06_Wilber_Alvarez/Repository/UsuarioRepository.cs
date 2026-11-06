using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebAPI_2026._11._06_Wilber_Alvarez.Data;
using WebAPI_2026._11._06_Wilber_Alvarez.Model;

namespace WebAPI_2026._11._06_Wilber_Alvarez.Repository
{
    public class UsuarioRepository
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioRepository(AppDbContext appDbContext) { 
            _appDbContext = appDbContext;
        }

        public async Task<Usuario?> Get(int id) {
            
            return await _appDbContext.Usuarios.AsNoTracking().FirstOrDefaultAsync(u  => u.Id == id);
        }

        public async Task<List<Usuario>> GetAll() { 
            var usuarios= await _appDbContext.Usuarios.AsNoTracking().ToListAsync();
            return usuarios.ToList();
        }

        public async Task<Usuario> Save(Usuario usuario)
        {
            await _appDbContext.Usuarios.AddAsync(usuario);
            await _appDbContext.SaveChangesAsync();
            return usuario;
        }
    }
}
