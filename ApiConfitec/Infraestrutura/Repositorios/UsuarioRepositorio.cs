using ApiConfitec.Core.DTO;
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
            var usu = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usu);
            await _context.SaveChangesAsync();
        }

        public async Task<UsuarioDTO> Get(int id)
        {
            var usu = await _context.Usuarios.FindAsync(id);
            if (usu != null)
            {
                return new UsuarioDTO
                {
                    Id = usu.Id,
                    Nome = usu.Nome,
                    SobreNome = usu.SobreNome,
                    Email = usu.Email,
                    DataNascimento = usu.DataNascimento.Date.ToString("dd/MM/yyyy"),
                    Escolaridade = usu.Escolaridade.ToString()
                };
            }
            else
            {
                throw new Exception("Usuario nao encontrado");
            }
        }

        public async Task<List<UsuarioDTO>> GetAll()
        {
            return await _context.Usuarios.Select(u => new UsuarioDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                SobreNome = u.SobreNome,
                Email = u.Email,
                DataNascimento = u.DataNascimento.Date.ToString("dd/MM/yyyy"),
                Escolaridade = u.Escolaridade.ToString()
            }).ToListAsync();
        }

        public async Task Update(Usuario usu)
        {
            _context.Usuarios.Update(usu);
            await _context.SaveChangesAsync();
        }
    }
}
