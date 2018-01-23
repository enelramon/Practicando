using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro2.ENTIDADES

{
    class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
       


        public Personas()
        {
            this.PersonaId = 0;
            this.Nombre = string.Empty;
         

        }

        public Personas(int personaId, string nombre)
        {
            this.PersonaId = personaId;
            this.Nombre = nombre;
           
        }
    }
}
