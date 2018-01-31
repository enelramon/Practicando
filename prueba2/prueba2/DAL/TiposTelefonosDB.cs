using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba2.Entidad;

namespace prueba2.DAL
{
    class TiposTelefonosDB : DbContext
    {
        public DbSet<TiposTelefonos> TipTelefonos { get; set; }



        public TiposTelefonosDB() : base("ConStr")
        {

        }
    }
}
