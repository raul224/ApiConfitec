using ApiConfitec.Core.DTO;
using ApiConfitec.Core.Entidades;

namespace ApiConfitec.Core.IRepositorios
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioDTO>> GetAll();
        Task<UsuarioDTO> Get(int id);
        Task Create(Usuario usu);
        Task Update(Usuario usu);
        Task Delete(int id);
    }
}
