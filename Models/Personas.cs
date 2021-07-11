using System;
using System.ComponentModel.DataAnnotations;


namespace ApiPrestamos.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la cédula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la dirección")]
        public string Direccion { get; set; }

        public decimal Balance { get; set; } = 0;

        public DateTime Nacmiento { get; set; } = DateTime.Now;
    }
}
