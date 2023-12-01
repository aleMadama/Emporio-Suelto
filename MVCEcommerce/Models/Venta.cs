using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEcommerce.Models
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public double Total { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
