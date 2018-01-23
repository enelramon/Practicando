using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructuraEnlaza
{
    public class Nodo
    {
        public string NombreD { get; set; }
        public string NombreP { get; set; }
         public  Nodo sigte;
        public Nodo(string NombreP, string NombreD)
        {
            this.NombreD = NombreD;
            this.NombreP = NombreP;
            this.sigte = null;

        }
    }
}
