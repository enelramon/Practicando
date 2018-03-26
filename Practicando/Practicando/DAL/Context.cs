using Practicando.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando.DAL
{
    class Context: DbContext
    {
        public Context(): base("ConStr")
        {
           
        }

        public DbSet<Personas> PersonaContext { get; set; }
        public DbSet<PersonasTelefonos> TelefonoContext { get; set; }
    }
}
