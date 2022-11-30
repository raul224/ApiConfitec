using ApiConfitec.Core.Entidades;
using ApiConfitec.Core.IRepositorios;

namespace ApiConfitec.Core.Services
{
    public class UsuarioService
    {
        private IUsuarioRepositorio _repositorio { get; }

        public UsuarioService(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _repositorio.GetAll();
        }

        public async Task<Usuario> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task Create(Usuario usu)
        {
            await _repositorio.Create(usu);
        }

        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task Update(Usuario usu)
        {
            await _repositorio.Update(usu);
        }
    }
}
