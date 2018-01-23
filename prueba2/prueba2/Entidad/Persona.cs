using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba2.Entidad
{
    class Persona
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombres { get; set; }

        public Persona()
        {
            this.PersonaId = 0;
            this.Nombres = string.Empty;
        }

        public Persona(int personaId, string nombres)
        {
            this.PersonaId =personaId;
            this.Nombres = nombres;
        }
    }
}
