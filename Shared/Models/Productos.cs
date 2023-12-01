using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaMariaSolution.Shared.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripción { get; set; }
        public float Existencia { get; set; }
        public float Precio { get; set; }
        public byte[]? Imagen { get; set; }
    }
}
