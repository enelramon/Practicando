using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro2.ENTIDADES;

namespace Registro2.DAL
{
    class PersonaDB:DbContext 
    {
        public virtual DbSet<Personas> Persona { get; set; }

        public PersonaDB():base("ConStr")
        {

        }


    }
   

    
}
