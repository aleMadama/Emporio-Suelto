using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCEcommerce.Models
{
    public class Carrito
    {
        public Producto Producto { get; set; }
        public Usuario Usuario { get; set; }
    }
}
