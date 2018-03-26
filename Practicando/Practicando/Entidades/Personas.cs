using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando.Entidades
{
    class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public virtual List<PersonasTelefonos> TelefonosPersona { get; set; }

        public Personas()
        {
            this.PersonaId = 0;
            this.Nombres = string.Empty;
            this.TelefonosPersona = new List<PersonasTelefonos>();
        }

        public Personas(int Id, string Nombre, List<PersonasTelefonos> detalles)
        {
            this.PersonaId =Id;
            this.Nombres = Nombre;
            this.TelefonosPersona = detalles;

        }
    }

   
}
