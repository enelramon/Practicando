using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LewisVentas.ENTIDADES;

namespace LewisVentas.DAL
{
    class Context:DbContext
    {
        public Context():base("ConStr")
        {

        }

        public DbSet<Users> Usuario { get; set; }
    }
}
