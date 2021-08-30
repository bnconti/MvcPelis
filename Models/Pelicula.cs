using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPelis.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
    }
}
