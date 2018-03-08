using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Entidades
{
   public class Clientes
    {
        [Key]
        public int IdClientes { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public virtual List<Telefono_detalles> Telefonos_Detalles { get; set; }

        public Clientes()
        {
            this.IdClientes = 0;
            this.Nombre = string.Empty;
            this.Telefonos_Detalles = new List<Telefono_detalles>();
            this.Fecha = DateTime.Now;
        }

        public Clientes(int idCliente, string nombre, List<Telefono_detalles> detalles, DateTime fecha)
        {
            this.Fecha = Fecha;
            this.IdClientes = idCliente;
            this.Nombre = nombre;
            this.Telefonos_Detalles = detalles;
        }
    }
}
