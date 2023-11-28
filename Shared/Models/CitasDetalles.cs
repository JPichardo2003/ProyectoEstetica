using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaMariaSolution.Shared.Models
{
    public class CitasDetalles
    {
        [Key]
        public int DetalleId { get; set; }
        
        public int CitaId {  get; set; }

        public int CantidadUtilizada { get; set; }

        public int ProductoId { get; set; }
    }
}
