using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenDetalles.Entidades;
using ExamenDetalles.DAL;

namespace ExamenDetalles.BLL
{
    class ClienteBLL
    {

        public static bool Guardar(Clientes cliente)
        {
            bool flag = false;

            try
            {
                Context db = new Context();
                db.cliente.Add(cliente);
                db.SaveChanges();
                int id = cliente.IdClientes;
                foreach (Telefono_Detalles telefono_detalle in cliente.Telefonos_Detalles)
                { 
                   
                    db.Detalles.Add(telefono_detalle);
                    db.SaveChanges();
                }



                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }
    }
}

