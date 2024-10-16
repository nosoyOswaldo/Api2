using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Entity
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int Id_Producto { get; set; }
        public string? NombreProducto { get; set; }
        public int? Precio { get; set;}
    }
}
