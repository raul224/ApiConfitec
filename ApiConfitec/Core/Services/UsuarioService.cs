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
            var list = await _repositorio.GetAll();
            if (!list.Any())
            {
                return new List<Usuario>();
            }else
            {
                return list;
            }
        }

        public async Task<Usuario> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task Create(Usuario usu)
        {
            if(usu.DataNascimento >= DateTime.Now)
            {
                throw new Exception("Data invalida");
            }

            if(!usu.Email.Contains("@"))
            {
                throw new Exception("Email invalido");
            }

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
