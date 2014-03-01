using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoWeb.Models
{
    public class ProyectoDb : DbContext
    {
        public ProyectoDb()
            : base("DefaultConnection")
        {

        }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<Recomendacion> Recomendaciones { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
    }
}
