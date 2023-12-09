using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaMariaSolution.Shared.Models
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public int ClienteId { get; set; }
        public int ColaboradorId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Campo es requerido.")]
        public string? Asunto { get; set; }
        public float Monto { get; set; }
        public bool Llego { get; set; } = true;
        
        public List<TiposDeTrabajos> TiposDeTrabajos { get; set; } = new List<TiposDeTrabajos>();

        [ForeignKey("CitaId")]
        public ICollection<CitasDetalles> CitasDetalles { get; set; } = new List<CitasDetalles>();
    }
}
