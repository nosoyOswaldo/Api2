using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Entity
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int Id_Pedido { get; set;}
        public string Producto { get; set;}
        [ForeignKey ("Id_Usuario")]
        public int? Id_Usuario { get; set;}
        public Usuario? Usuario { get; set;}

    }
}
