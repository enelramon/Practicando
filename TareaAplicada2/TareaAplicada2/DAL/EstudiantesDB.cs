using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaAplicada2.Entidades;

namespace TareaAplicada2.DAL
{
    class EstudiantesDB:DbContext 
    {
        public DbSet<Estudiantes> Estudiante { get; set; }

        public EstudiantesDB():base("ConStr")
        {

        }

      
    }
}
