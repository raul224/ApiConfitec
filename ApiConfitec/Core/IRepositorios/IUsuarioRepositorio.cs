using ApiConfitec.Core.Entidades;

namespace ApiConfitec.Core.IRepositorios
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> GetAll();
        Task<Usuario> Get(int id);
        Task Create(Usuario usu);
        Task Update(Usuario usu);
        Task Delete(int id);
    }
}
