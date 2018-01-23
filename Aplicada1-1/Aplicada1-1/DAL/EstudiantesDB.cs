using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Aplicada1_1.Entidades;
namespace Aplicada1_1.DAL
{
    class EstudiantesDB :DbContext
    {
        public EstudiantesDB() : base("ConStr")
        {
                
        }

        public DbSet<Estudiantes> Estudiante { get; set; }
      
    }
}
