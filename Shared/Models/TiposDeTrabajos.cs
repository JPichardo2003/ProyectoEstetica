using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaMariaSolution.Shared.Models
{
    public class TiposDeTrabajos
    {
        [Key]
        public int TipoDeTrabajoId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int TiempoEstimado { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public float Precio { get; set; }
    }
}
