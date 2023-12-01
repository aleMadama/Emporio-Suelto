using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCEcommerce.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        [EnumDataType(typeof(Categoria))]
        public Categoria Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }
        [Display(Name = "Fecha inscripción")]
        public DateTime FechaInscripto { get; set; }
        //public Boolean paraCarrito { get; set; }

    }
}
