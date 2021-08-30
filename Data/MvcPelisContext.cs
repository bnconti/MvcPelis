using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPelis.Models;

namespace MvcPelis.Data
{
    public class MvcPelisContext : DbContext
    {
        public MvcPelisContext (DbContextOptions<MvcPelisContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPelis.Models.Pelicula> Pelicula { get; set; }
    }
}
