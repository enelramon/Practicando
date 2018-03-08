using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2.Entidades;
using Examen2.DAL;

namespace Examen2.BLL
{
    class ClientesBLL
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
                foreach (Telefono_detalles telefono_detalle in cliente.Telefonos_Detalles)
                {
                   
                    
                    db.telefono.Add(telefono_detalle);
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
