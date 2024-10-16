using WebApplication.Entity;

namespace WebApplication.Interface
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAll();
        Task<Usuario> GetById(int Id_Usuario);
        Task<Usuario> Create(Usuario Usuario1);
        Task<Usuario> Update(Usuario Usuario1);
        Task<int> Delete(Usuario Usuario1);
    }
}
