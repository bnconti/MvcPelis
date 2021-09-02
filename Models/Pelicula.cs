using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPelis.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required, StringLength(60, MinimumLength = 3)]
        public string Titulo { get; set; }

        [Display(Name = "Fecha de lanzamiento"), DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [Required, StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Genero { get; set; }

        [Column(TypeName = "decimal(18, 2)"), DataType(DataType.Currency), Range(1, 100)]
        public decimal Precio { get; set; }

        [Range(1, 10)]
        public int Puntaje { get; set; }
    }
}
