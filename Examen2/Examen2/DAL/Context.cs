using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Entidades;

namespace Examen2.DAL
{
    class Context: DbContext 
    {
        public Context(): base("ConStr")
        {

        }

        public DbSet<Telefono_detalles> telefono { get; set; }
        public DbSet<Clientes> cliente { get; set; }
    }
}
