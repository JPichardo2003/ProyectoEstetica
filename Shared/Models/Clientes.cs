﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaMariaSolution.Shared.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del cliente")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido del cliente")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingresar el email del cliente")]
        [EmailAddress(ErrorMessage = "Debe ingresar un email valido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar una clave")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,100}$", ErrorMessage = "La contraseña debe tener más de 8 caracteres, al menos un dígito, al menos una minúscula y al menos una mayúscula.")]
        public string? Clave { get; set; }

        [Required(ErrorMessage = "Debe ingresar el telefono del cliente")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el telefono correctamente, Ejemplo: 8094587412")]
        public string? Teléfono { get; set; }

        public bool Baneado { get; set; } = false;

        [ForeignKey("ClienteId")]
        public ICollection<Citas> Citas { get; set; } = new List<Citas>();
    }
}
