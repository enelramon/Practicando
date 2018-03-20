using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Entidades
{
  public  class Telefono_detalles
    {
        [Key]
        public int IdTelefonoDetalles{ get; set; }
        
        public int Clientes_IdClientes { get; set; }
        public string Tipo_telefono { get; set; }
        public int Numero { get; set; }

        public Telefono_detalles()
        {
            this.IdTelefonoDetalles = 0;
            this.Clientes_IdClientes = 0;
            this.Tipo_telefono = string.Empty;
            this.Numero = 0;
        }

        public Telefono_detalles(int idTelefonoDetalles, int idCliente, string tipo_Telefono, int numero )
        {
            this.IdTelefonoDetalles = idTelefonoDetalles;
            this.Clientes_IdClientes = idCliente;
            this.Tipo_telefono = tipo_Telefono;
            this.Numero = numero;

        }
        public Telefono_detalles(string tipo_Telefono, int numero)
        {
            
            this.Tipo_telefono = tipo_Telefono;
            this.Numero = numero;

        }



    }
}
