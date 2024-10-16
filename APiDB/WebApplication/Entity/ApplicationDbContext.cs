using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Entity
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Pedido> pedido { get; set; }
        public DbSet<PedidoProducto> pedidoProducto { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
