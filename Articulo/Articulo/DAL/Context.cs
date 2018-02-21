﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Articulo.Entidades;

namespace Articulo.DAL
{
    class Context: DbContext
    {
        public Context():base("ConStr")
        {


        }

        public DbSet<Articulos> articulo { get; set; }

    }
}
