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
             
                

                int id = cliente.IdClientes;
                foreach (Telefono_detalles telefono_detalle in cliente.Telefonos_Detalles)
                {
                    telefono_detalle.Clientes_IdClientes = cliente.IdClientes;
                    
                    db.telefono.Add(telefono_detalle);
                  
                }

                db.SaveChanges();
                
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }
        public static Clientes Buscar(int Id)
        {
           Clientes cliente = new Clientes();
            try
            {
                Context context = new Context();
                cliente = context.cliente.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return cliente;

        }

        public static bool Eliminar(int Id)
        {
           Clientes clientes = null;
            bool estado = false;
            try
            {
                Context context = new Context();
                clientes = context.cliente.Find(Id);
                //context.telefono.RemoveRange(context.telefono.Where(x => x.IdCliente == clientes.IdClientes));
                context.cliente.Remove(clientes);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;


            }
            return estado;
        }
    }
}
