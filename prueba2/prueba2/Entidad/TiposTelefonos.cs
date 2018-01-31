using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace prueba2.Entidad
{
    class TiposTelefonos
    {
        [Key]
        public int TipoId { get; set; }
        public string TipoNumero { get; set; }
        public string Descripcion { get; set; }

        public TiposTelefonos()
        {
            this.TipoId = 0;
            this.TipoNumero = string.Empty;
            this.Descripcion = string.Empty;
           
        }

        public TiposTelefonos(int tipoId, string tipoNumero,  string descripcion)
        {
            this.TipoId = tipoId;
            this.TipoNumero = tipoNumero;
            this.Descripcion = descripcion;
           

        }


    }
}
