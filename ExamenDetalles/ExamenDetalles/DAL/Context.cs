using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenDetalles.Entidades;

namespace ExamenDetalles.DAL
{
    class Context: DbContext
    {
        public Context() : base("ConStr")
        {

        }

        public DbSet<Telefono_Detalles> Detalles { get; set; }
        public DbSet<Clientes> cliente { get; set; }
    }
}
