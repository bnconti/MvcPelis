using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcPelis.Models
{
    public class PelisGeneroViewModel
    {
        public List<Pelicula> Peliculas { get; set; }
        public SelectList Generos { get; set; }
        public string GeneroSeleccionado { get; set; }
        public string StrBusqueda { get; set; }
    }
}
