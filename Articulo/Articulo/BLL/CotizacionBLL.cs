using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Articulo.Entidades;
using Articulo.DAL;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Articulo.BLL
{
    public class CotizacionBLL
    {
        public static bool Guardar(Cotizaciones cotizaciones, Cotizaciones_detalles[] cotizaciones_Detalles)
        {
            bool estado = false;
            try
            {   //guardando cotizacion
                Context context = new Context();
                context.cotizacion.Add(cotizaciones);
                context.SaveChanges();
                int id = cotizaciones.CotizacionesId;

                //guardando detalles de cotizacion
                foreach (Cotizaciones_detalles datos in cotizaciones_Detalles)
                {
                    Cotizaciones_detalles cd = new Cotizaciones_detalles();
                    cd.CotizacionesId = id;
                    cd.ArticuloId = datos.ArticuloId;
                    cd.Cantidad = datos.Cantidad;
                    cd.Precio = datos.Precio;
                    cd.Total = datos.Total;
                    context.cotizacion_detalles.Add(cd);
                    context.SaveChanges();
                }
                
                
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static Cotizaciones  BuscarCotizacion(int Id)
        {
            Cotizaciones cotizaciones = new Cotizaciones();
            try
            {
                Context context = new Context();
               cotizaciones = context.cotizacion.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return cotizaciones;

        }

        public static List<Cotizaciones_detalles>  BuscarDetallesCotizacion(Expression<Func<Cotizaciones_detalles, bool>> filter)
        {
            List<Cotizaciones_detalles> lista = null;

           Cotizaciones_detalles cotizaciones_Detalles = new Cotizaciones_detalles();
            try
            {
                Context context = new Context();
                lista = context.cotizacion_detalles.Where(filter).ToList(); 

            }
            catch (Exception)
            {
                throw;
            }

            return lista;

        }

        public static bool Eliminar(int Id)
        {
           Cotizaciones cotizaciones = null;
            bool estado = false;
            try
            {
                Context context = new Context();
                cotizaciones = context.cotizacion.Find(Id);
                context.cotizacion.Remove(cotizaciones);
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
