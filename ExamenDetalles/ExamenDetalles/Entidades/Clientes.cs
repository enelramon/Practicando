using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenDetalles.Entidades
{
    class Clientes
    {
        [Key]
        public int IdClientes { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<Telefono_Detalles> Telefonos_Detalles { get; set; }

        public Clientes()
        {
            this.IdClientes = 0;
            this.Nombre = string.Empty;
            this.Telefonos_Detalles = new List<Telefono_Detalles>();
            this.Fecha = DateTime.Now;
        }

        public Clientes(int idCliente, string nombre, List<Telefono_Detalles> detalles, DateTime fecha)
        {
            this.Fecha = Fecha;
            this.IdClientes = idCliente;
            this.Nombre = nombre;
            this.Telefonos_Detalles = detalles;
        }
    }
}
