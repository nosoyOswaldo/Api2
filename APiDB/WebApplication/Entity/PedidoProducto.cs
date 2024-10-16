using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Entity
{
    [Table("PedidoProducto")]
    public class PedidoProducto
    {
        [Key]
        public int Id_PedidoProducto { get; set; }
        [ForeignKey("Id_Pedido")]
        public int Id_Pedido { get; set; }
        public Pedido? Pedido { get; set; }
        [ForeignKey("Id_Producto")]
        public int Id_Producto { get; set; }
        public Producto? Producto { get; set; }
    }
}
