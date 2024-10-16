using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Entity
{
    [Table("Ususario")]
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        [Required]
        public string? Nombrecli { get; set; }
        public string? Email { get; set; }
    }
}
