using prueba2.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba2.DAL
{
    class PersonasDB:DbContext
    {
        public DbSet<Persona> per  { get; set; }



        public PersonasDB() : base("ConStr")
        {
            
        }
    }
}
