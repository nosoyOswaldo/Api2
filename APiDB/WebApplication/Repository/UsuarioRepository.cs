using WebApplication.Entity;
using WebApplication.Interface;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;
        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task <Usuario> GetById(int id)
        {
            return _context.usuario.Where(x => x.Id_Usuario == id).FirstOrDefault();
        }
        public async Task<Usuario> Create(Usuario Usuario1)
        {
            _context.usuario.Add(Usuario1);
            _context.SaveChanges();
            return Usuario1;
        }
        public async Task<int> Delete(Usuario Usuario1)
        {
            _context.usuario.Remove(Usuario1);
            return _context.SaveChanges();
        }
        public async Task<List<Usuario>> GetAll()
        {
            return _context.usuario.ToList();
        }
        public async Task<Usuario> Update(Usuario Usuario1)
        {
            _context.Entry(Usuario1).State = EntityState.Modified;
            _context.SaveChanges();
            return Usuario1;
        }
    }
}
