using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando.Entidades
{
    class PersonasTelefonos
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("IdPersona")]
        public int IdPersona { get; set; }
        public string Tipo{ get; set; }
        public int Telefono { get; set; }

        public PersonasTelefonos()
        {
            this.Id = 0;
            this.Tipo = string.Empty;
            this.Telefono = 0;
            this.IdPersona = 0;
        }

        public PersonasTelefonos(int IdTelefonos, string TipoTelefono, int NumeroTelefono, int Idpersonas)
        {
            this.Tipo = TipoTelefono;
            this.Telefono = NumeroTelefono;
         
        }
    }

    
}
