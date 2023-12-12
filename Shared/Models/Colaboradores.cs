using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaMariaSolution.Shared.Models
{
    public class Colaboradores
    {
        [Key]
        public int ColaboradorId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Dirección { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el telefono correctamente, Ejemplo: 8094587412")]
        public string? Teléfono { get; set; }
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el Celular correctamente, Ejemplo: 8294587412")]

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Celular { get; set; }

        public bool Activo { get; set; } = true;

        [ForeignKey("ColaboradorId")]
        public ICollection<Citas>? Citas { get; set; } = new List<Citas>();

    }

}
