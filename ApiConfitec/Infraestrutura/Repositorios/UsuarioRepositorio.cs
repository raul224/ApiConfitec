using ApiConfitec.Core.Entidades;
using ApiConfitec.Core.IRepositorios;
using Microsoft.EntityFrameworkCore;

namespace ApiConfitec.Infraestrutura.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Context _context;

        public UsuarioRepositorio(Context context)
        {
            _context = context;
        }

        public async Task Create(Usuario usu)
        {
            await _context.Usuarios.AddAsync(usu);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Usuario usu = await Get(id);
            _context.Usuarios.Remove(usu);
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario> Get(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task Update(Usuario usu)
        {
            _context.Usuarios.Update(usu);
            await _context.SaveChangesAsync();
        }
    }
}
