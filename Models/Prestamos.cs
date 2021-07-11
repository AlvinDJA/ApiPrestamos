using System;
using System.ComponentModel.DataAnnotations;

namespace ApiPrestamos.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Es obligatorio introducir una persona")]
        public int PersonaId { get; set; }
        
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un monto"), Range(minimum: 1, maximum: 50000000, ErrorMessage = "Debe tener un minimo de 1")]
        public decimal Monto { get; set; } 
        public decimal Balance { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            PersonaId = 0;
            Concepto = "";
            Monto = 0;
            Balance = 0;
        }
    }
}
